using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;
namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class activityController : ControllerBase
    {

        private readonly activityContext _activityContext;   //先在全域宣告資料庫物件

        public activityController(activityContext activitycontext)
        {
            _activityContext = activitycontext;
        }

        //SubmissionTimeData - 填寫問卷的小時分布
        //這個方法會根據 feedback 表中的 created_at 字段，統計不同小時（0-23）的提交數量
        [HttpGet("SubmissionTimeData")]
        public IActionResult GetSubmissionTimeData()
        {
            var hourGroups = _activityContext.feedback
                .Where(f => f.created_at.HasValue)
                .GroupBy(f => f.created_at.Value.Hour)
                .Select(g => new
                {
                    Hour = g.Key,
                    Count = g.Count()
                })
                .OrderBy(g => g.Hour)
                .ToList();

            var result = new
            {
                hours = hourGroups.Select(x => x.Hour).ToArray(),
                counts = hourGroups.Select(x => x.Count).ToArray()
            };

            return Ok(result);
        }

        // ColorDistribution - 顏色分布
        //這個方法根據 color_preferences 中的 message_board_color2 字段，統計每個顏色（紅、橙、黃、綠、藍、靛、紫）的選擇數量。
        [HttpGet("ColorDistribution")]
        public IActionResult GetColorDistribution()
        {
            var colors = new[] { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            var colorCounts = colors.Select(color => new
            {
                Color = color,
                Count = _activityContext.color_preferences.Count(c => c.message_board_color2 == color)
            }).ToList();

            var result = new
            {
                colors = colorCounts.Select(c => c.Color).ToArray(),
                counts = colorCounts.Select(c => c.Count).ToArray()
            };

            return Ok(result);
        }


        // AgeData - 年齡範圍分布
        //這個方法會從 participants 表中，統計不同年齡範圍的人數
        [HttpGet("AgeData")]
        public IActionResult GetAgeData()
        {
            var ageGroups = _activityContext.participants
                .GroupBy(p => p.age_range)
                .Select(g => new
                {
                    AgeRange = g.Key,
                    Count = g.Count()
                })
                .OrderBy(g => g.AgeRange) // 可根據需求調整排序
                .ToList();

            var result = new
            {
                ageRanges = ageGroups.Select(x => x.AgeRange).ToArray(),
                counts = ageGroups.Select(x => x.Count).ToArray()
            };

            return Ok(result);
        }

        // SocialData - 社群數據
        //這個方法會根據 social_check_in 表中的 platform 字段，統計每個社群平台的使用情況
        [HttpGet("SocialData")]
        public IActionResult GetSocialData()
        {
            var platformGroups = _activityContext.social_check_in
                .Where(s => !string.IsNullOrEmpty(s.platform))
                .GroupBy(s => s.platform)
                .Select(g => new
                {
                    Platform = g.Key,
                    Count = g.Count()
                })
                .ToList();

            var result = new
            {
                platforms = platformGroups.Select(x => x.Platform).ToArray(),
                values = platformGroups.Select(x => x.Count).ToArray()
            };

            return Ok(result);
        }


        [HttpPost("SubmitSurvey")]
        public async Task<IActionResult> SubmitSurvey([FromBody] SurveySubmissionDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // 建立參與者的基本資料
            var participant = new participants
            {
                gender = dto.Gender,
                age_range = dto.AgeRange,
                created_at = DateTime.Now
            };

            _activityContext.participants.Add(participant);
            await _activityContext.SaveChangesAsync();

            // 儲存社群打卡參與狀況
            var socialCheckIn = new social_check_in
            {
                participant_id = participant.id,
                is_check_in = dto.IsCheckIn,
                platform = dto.IsCheckIn == "是" ? dto.Platform : null,
                created_at = DateTime.Now
            };

            _activityContext.social_check_in.Add(socialCheckIn);
            await _activityContext.SaveChangesAsync();

            // 儲存顏色選擇統計
            var colorPreferences = new color_preferences
            {
                participant_id = participant.id,
                message_board = dto.MessageBoard,
                message_board_color1 = dto.MessageBoard == "是" ? dto.MessageBoardColor1 : null,
                message_board_color2 = dto.MessageBoard == "是" ? dto.MessageBoardColor2 : null,
                balloon = dto.Balloon,
                balloon_color1 = dto.Balloon == "是" ? dto.BalloonColor1 : null,
                balloon_color2 = dto.Balloon == "是" ? dto.BalloonColor2 : null,
                created_at = DateTime.Now
            };

            _activityContext.color_preferences.Add(colorPreferences);
            await _activityContext.SaveChangesAsync();

            // 儲存反饋與觀察
            var feedback = new feedback
            {
                participant_id = participant.id,
                color_choice = dto.ColorChoice,
                color_choice_text = dto.ColorChoice == "其他" ? dto.ColorChoiceText : null,
                satisfaction = dto.Satisfaction,
                feedback_text = dto.FeedbackText,
                promoter_observation = dto.PromoterObservation,
                others = dto.Others,
                created_at = DateTime.Now
            };

            _activityContext.feedback.Add(feedback);
            await _activityContext.SaveChangesAsync();

            return Ok(new { message = "Survey submitted successfully!" });
        }

    }
}
