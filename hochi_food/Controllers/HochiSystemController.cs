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
using System.Globalization;

namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class HochiSystemController : ControllerBase
    {
        private readonly HochiSystemContext _hochiSystemContext;   //先在全域宣告資料庫物件

        public HochiSystemController(HochiSystemContext hochisystemcontext)
        {
            _hochiSystemContext = hochisystemcontext;
        }

        [HttpGet("CourseBanners")]
        public async Task<ActionResult<IEnumerable<CourseBannerDto>>> GetCourseBanners()
        {
            var today = DateTime.Today;

            var courses = await _hochiSystemContext.HCourse
                .AsNoTracking()
                .Where(c =>
                    c.HStatus == 1
                    && c.HType == "1"
                    && c.HIRestriction != null
                    && c.HIRestriction.StartsWith("1,")
                    && (c.HSerial == 0 || c.HSerial == 1 || c.HSerial == 3) // ✅ 同步 SQL
                )
                .Select(c => new
                {
                    c.HCourseName,
                    c.HDateRange,
                    c.HContentTitle,
                    c.HContent,
                    c.HImg,
                    c.HSerial
                })
                .ToListAsync();

            var filtered = courses
                .Where(c => IsInTargetDate(c.HSerial, c.HDateRange, today))  // ✅ 同步 SQL
                .GroupBy(c => new { c.HCourseName, c.HDateRange, c.HContentTitle, c.HContent, c.HImg, c.HSerial })
                .Select(g => new CourseBannerDto
                {
                    HCourseName = g.Key.HCourseName,
                    HDateRange = g.Key.HDateRange,
                    HContentTitle = g.Key.HContentTitle,
                    HContent = g.Key.HContent,
                    HImg = g.Key.HImg,
                    HSerial = g.Key.HSerial
                })
                .ToList();

            return Ok(filtered);
        }

        private static bool IsInTargetDate(int? serial, string dateRange, DateTime today)
        {
            if (serial == null) return false;

            var s = serial.Value;
            var t = today.Date;
            var dr = (dateRange ?? "").Trim();
            if (dr.Length == 0) return false;

            bool isRange = dr.Contains("-"); // 區間格式：yyyy/MM/dd - yyyy/MM/dd

            // 1) 區間格式：Start ~ End
            if (isRange)
            {
                if (!TryParseRange(dr, out var start, out var end)) return false;

                if (s == 1)
                {
                    // SQL: @Today BETWEEN RangeStart AND RangeEnd
                    return t >= start && t <= end;
                }

                if (s == 0 || s == 3)
                {
                    // SQL: @Today >= DATEADD(day,-15,start) AND @Today < start
                    var promoStart = start.AddDays(-15);
                    return t >= promoStart && t < start;
                }

                return false;
            }

            // 2) 逗號多日期：抓 HasToday + MinDate
            var dates = ParseDateList(dr);
            if (dates.Count == 0) return false;

            var minDate = dates.Min();
            bool hasToday = dates.Contains(t);

            if (s == 1)
            {
                // SQL: HasToday=1 OR (today in [minDate-15, minDate))
                if (hasToday) return true;

                var promoStart = minDate.AddDays(-15);
                return t >= promoStart && t < minDate;
            }

            if (s == 0 || s == 3)
            {
                var promoStart = minDate.AddDays(-15);
                return t >= promoStart && t < minDate;
            }

            return false;
        }

        private static bool TryParseRange(string dr, out DateTime start, out DateTime end)
        {
            start = default;
            end = default;

            // 支援：2026/12/01 - 2026/12/31（中間可能有空白）
            var idx = dr.IndexOf('-');
            if (idx <= 0) return false;

            var left = dr.Substring(0, idx).Trim();
            var right = dr.Substring(idx + 1).Trim();

            return TryParse111(left, out start) && TryParse111(right, out end);
        }

        private static List<DateTime> ParseDateList(string dr)
        {
            // 支援半形逗號/全形逗號、以及可能的空白
            var norm = dr.Replace('，', ',');
            var parts = norm.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<DateTime>();
            foreach (var p in parts)
            {
                if (TryParse111(p.Trim(), out var d))
                    list.Add(d.Date);
            }
            return list;
        }

        private static bool TryParse111(string s, out DateTime d)
        {
            // SQL style 111 = yyyy/MM/dd
            return DateTime.TryParseExact(
                s,
                "yyyy/MM/dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out d
            );
        }

    }
}
