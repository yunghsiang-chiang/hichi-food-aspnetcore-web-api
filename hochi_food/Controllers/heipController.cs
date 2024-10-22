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
namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class heipController : ControllerBase
    {
        private readonly heipContext _heipContext;

        public heipController(heipContext heipContext)
        {
            _heipContext = heipContext;
        }

        // 追加的 HttpPost - Submit the exhibition survey data
        [HttpPost("SubmitExhibition")]
        public async Task<IActionResult> SubmitExhibition([FromBody] ExhibitionDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.userId))
            {
                return BadRequest("Invalid form data");
            }

            // 檢查是否已經提交過
            var existingExhibition = await _heipContext.exhibition
                .FirstOrDefaultAsync(e => e.userId == dto.userId && e.attendanceDate == dto.attendanceDate);

            if (existingExhibition != null)
            {
                return Conflict("This user has already submitted the survey today.");
            }

            // 新增新的展覽問卷數據
            var exhibition = new exhibition
            {
                userId = dto.userId,
                colorGroup = dto.colorGroup,
                color = dto.color,
                IsAttendance = dto.IsAttendance,
                attendanceDate = dto.attendanceDate
            };

            _heipContext.exhibition.Add(exhibition);
            await _heipContext.SaveChangesAsync();

            return Ok(new { message = "Survey submitted successfully!" });
        }
    }
}
