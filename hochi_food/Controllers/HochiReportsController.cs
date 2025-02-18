using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class HochiReportsController : ControllerBase
    {
        private readonly HochiReportsContext _hochiReportsContext;   //先在全域宣告資料庫物件
        private readonly HochiSystemContext _hochiSystemContext;   //先在全域宣告資料庫物件

        public HochiReportsController(HochiReportsContext hochireportscontext, HochiSystemContext hochisystemcontext)
        {
            _hochiReportsContext = hochireportscontext;
            _hochiSystemContext = hochisystemcontext;  // 確保 _hochiSystemContext 不會是 null
        }


        //GET API

        [HttpGet("GetTableSchema")]
        public async Task<IActionResult> GetTableSchema()
        {
            var schemaData = await _hochiReportsContext.TableSchema
                .Select(t => new
                {
                    t.table_name,
                    t.column_name,
                    t.column_type,
                    allowed_functions = JsonConvert.DeserializeObject<List<string>>(t.allowed_functions ?? "[]") // 確保為 List<string>
                })
                .ToListAsync();

            return Ok(new { values = schemaData });
        }






        [HttpGet("GetReportData")]
        public async Task<IActionResult> GetReportData(string table, string column, string function, string? keyword = null)
        {
            if (string.IsNullOrEmpty(table) || string.IsNullOrEmpty(column) || string.IsNullOrEmpty(function))
            {
                return BadRequest("缺少必要參數");
            }

            string database = table == "TableSchema" || table == "UserReports" ? "HochiReports" : "HochiSystem";

            // 確認是否為數值欄位
            bool isNumericColumn = column.ToLower().Contains("id") || column.ToLower().Contains("age") || column.ToLower().Contains("count");

            string sql;

            if (function == "FILTER BY KEYWORD")
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    return BadRequest("關鍵字 (keyword) 不能為空");
                }

                sql = $"SELECT {column} FROM [{database}].[dbo].[{table}] WHERE {column} LIKE @Keyword";
            }
            else if (function == "GROUP BY")
            {
                string isNullReplacement = isNumericColumn ? "0" : "'未知'"; // 避免數字欄位出現 varchar 值
                sql = $"SELECT ISNULL(CAST({column} AS NVARCHAR), {isNullReplacement}) AS label, COUNT(*) AS value " +
                      $"FROM [{database}].[dbo].[{table}] " +
                      $"GROUP BY {column}";
            }
            else
            {
                sql = $"SELECT {function}({column}) AS value FROM [{database}].[dbo].[{table}]";
            }

            List<ReportResult> reportData = new List<ReportResult>();

            try
            {
                using (var connection = database == "HochiReports"
                    ? _hochiReportsContext.Database.GetDbConnection()
                    : _hochiSystemContext.Database.GetDbConnection())
                {
                    await connection.OpenAsync();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        // 如果是 "FILTER BY KEYWORD"，加上參數
                        if (function == "FILTER BY KEYWORD")
                        {
                            var param = command.CreateParameter();
                            param.ParameterName = "@Keyword";
                            param.Value = $"%{keyword}%";
                            command.Parameters.Add(param);
                        }

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                if (function == "GROUP BY")
                                {
                                    object label = isNumericColumn ? reader.GetValue(0) : reader.GetString(0);
                                    int value = reader.GetInt32(1);

                                    reportData.Add(new ReportResult
                                    {
                                        label = label.ToString(),
                                        value = value
                                    });
                                }
                                else
                                {
                                    reportData.Add(new ReportResult
                                    {
                                        label = function,
                                        value = reader.GetInt32(0)
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"SQL 執行錯誤: {ex.Message}");
            }

            return Ok(reportData);
        }


        [HttpGet("GetSavedReports/{userId}")]
        public async Task<IActionResult> GetSavedReports(string userId)
        {
            var reports = await _hochiReportsContext.UserReports
                .Where(r => r.user_id == userId)
                .OrderByDescending(r => r.created_at)
                .ToListAsync();

            // 確保不會發生 NULL 轉換錯誤
            var formattedReports = reports.Select(r => new
            {
                r.report_id,
                r.report_name,
                r.table_name,
                r.chart_type,
                r.x_axis,
                y_axes = string.IsNullOrEmpty(r.y_axes)
                    ? new List<string>()
                    : JsonConvert.DeserializeObject<List<string>>(r.y_axes) ?? new List<string>(), // 避免 NULL 轉換失敗

                r.category_field,
                r.stack_field,
                filters = string.IsNullOrEmpty(r.filters)
                    ? new Dictionary<string, string>()
                    : JsonConvert.DeserializeObject<Dictionary<string, string>>(r.filters) ?? new Dictionary<string, string>(), // 避免 NULL 轉換失敗

                r.created_at,
                r.is_public,
                r.share_code
            }).ToList();

            return Ok(formattedReports);
        }

        [HttpGet("GetReportByShareCode/{shareCode}")]
        public async Task<IActionResult> GetReportByShareCode(string shareCode)
        {
            var report = await _hochiReportsContext.UserReports
                .FirstOrDefaultAsync(r => r.share_code == shareCode);

            if (report == null)
                return NotFound("報表不存在");

            return Ok(report);
        }



        //POST API

        [HttpPost("SaveReport")]
        public async Task<IActionResult> SaveReport([FromBody] UserReports report)
        {
            if (string.IsNullOrEmpty(report.user_id) || string.IsNullOrEmpty(report.report_name))
            {
                return BadRequest(new { message = "缺少必要資訊" });
            }

            // 確保 y_axes 為 List<string>
            try
            {
                var yAxesList = report.y_axes_list ?? new List<string>();
                report.y_axes = JsonConvert.SerializeObject(yAxesList);
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Y 軸欄位格式錯誤，請使用 List<string>" });
            }

            // 確保 filters 為 JSON 物件
            report.filters = string.IsNullOrEmpty(report.filters) ? "{}" : report.filters;

            // 產生唯一分享碼
            report.share_code = Guid.NewGuid().ToString().Substring(0, 8);

            // 儲存至資料庫
            _hochiReportsContext.UserReports.Add(report);
            await _hochiReportsContext.SaveChangesAsync();

            return Ok(new { message = "報表已儲存", share_code = report.share_code });
        }



    }
}
