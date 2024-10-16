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
