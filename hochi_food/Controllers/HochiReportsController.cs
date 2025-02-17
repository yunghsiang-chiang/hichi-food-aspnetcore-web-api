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




        [HttpGet("GetTableSchema")]
        public async Task<IActionResult> GetTableSchema()
        {
            var schemaData = await _hochiReportsContext.TableSchema
                .Select(t => new
                {
                    t.table_name,
                    t.column_name,
                    t.column_type,
                    allowed_functions = t.allowed_functions != null ?
                        Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(t.allowed_functions) : new List<string>()
                })
                .ToListAsync();

            return Ok(schemaData);
        }


        [HttpGet("GetReportData")]
        public async Task<IActionResult> GetReportData(string table, string column, string function)
        {
            if (string.IsNullOrEmpty(table) || string.IsNullOrEmpty(column) || string.IsNullOrEmpty(function))
            {
                return BadRequest("缺少必要參數");
            }

            string database = table == "TableSchema" || table == "UserReports" ? "HochiReports" : "HochiSystem";

            string sql = $"SELECT ISNULL({column}, '未知') AS label, COUNT(*) AS value FROM [{database}].[dbo].[{table}] GROUP BY {column}";

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
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                reportData.Add(new ReportResult
                                {
                                    label = reader.GetString(0),
                                    value = reader.GetInt32(1)
                                });
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



    }
}
