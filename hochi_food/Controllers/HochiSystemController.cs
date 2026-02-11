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
                .Where(c => c.HStatus == 1 && c.HIRestriction != null && c.HIRestriction.StartsWith("1,") && (c.HSerial == 0 || c.HSerial == 1))
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
                .Where(c => IsInTargetDate(c.HSerial, c.HDateRange, today))
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

        private static bool IsInTargetDate(int? serial, string? dateRangeText, DateTime today)
        {
            if (serial != 0 && serial != 1)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(dateRangeText))
            {
                return false;
            }

            if (dateRangeText.Contains('-'))
            {
                var (rangeStart, rangeEnd) = ParseRangeDate(dateRangeText);
                if (rangeStart == null || rangeEnd == null)
                {
                    return false;
                }

                if (serial == 1)
                {
                    return today >= rangeStart.Value && today <= rangeEnd.Value;
                }

                return today < rangeStart.Value;
            }

            var dates = ParseCsvDates(dateRangeText);
            if (!dates.Any())
            {
                return false;
            }

            if (serial == 1)
            {
                return dates.Contains(today);
            }

            var minDate = dates.Min();
            return today < minDate;
        }

        private static (DateTime? StartDate, DateTime? EndDate) ParseRangeDate(string dateRangeText)
        {
            var splitIndex = dateRangeText.IndexOf('-');
            if (splitIndex <= 0)
            {
                return (null, null);
            }

            var startText = dateRangeText[..splitIndex].Trim();
            var endText = dateRangeText[(splitIndex + 1)..].Trim();

            var startDate = ParseDate(startText);
            var endDate = ParseDate(endText);

            return (startDate, endDate);
        }

        private static IEnumerable<DateTime> ParseCsvDates(string dateRangeText)
        {
            return dateRangeText
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(dateText => ParseDate(dateText.Trim()))
                .Where(parsedDate => parsedDate.HasValue)
                .Select(parsedDate => parsedDate!.Value)
                .Distinct();
        }

        private static DateTime? ParseDate(string dateText)
        {
            if (DateTime.TryParseExact(dateText, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate))
            {
                return parsedDate.Date;
            }

            return null;
        }
    }
}
