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
            var colorGroups = _activityContext.color_preferences
                .Where(c => !string.IsNullOrEmpty(c.message_board_color1) && !string.IsNullOrEmpty(c.message_board_color2))
                .GroupBy(c => c.message_board_color1)
                .Select(g => new
                {
                    MessageBoardColor1 = g.Key, // 分組依據
                    Colors = new
                    {
                        Red = g.Count(c => c.message_board_color2 == "紅"),
                        Orange = g.Count(c => c.message_board_color2 == "橙"),
                        Yellow = g.Count(c => c.message_board_color2 == "黃"),
                        Green = g.Count(c => c.message_board_color2 == "綠"),
                        Blue = g.Count(c => c.message_board_color2 == "藍"),
                        Indigo = g.Count(c => c.message_board_color2 == "靛"),
                        Purple = g.Count(c => c.message_board_color2 == "紫")
                    }
                })
                .ToList();

            var result = new
            {
                groups = colorGroups.Select(g => g.MessageBoardColor1).ToArray(),
                data = colorGroups.Select(g => new
                {
                    Colors = new int[] {
                g.Colors.Red,
                g.Colors.Orange,
                g.Colors.Yellow,
                g.Colors.Green,
                g.Colors.Blue,
                g.Colors.Indigo,
                g.Colors.Purple
            }
                }).ToArray()
            };

            return Ok(result);
        }

        //取得 participants 的性別比例
        //這個 API 將計算性別比例並返回。例如，男性和女性的比例
        [HttpGet("GenderRatio")]
        public IActionResult GetGenderRatio()
        {
            var maleCount = _activityContext.participants.Count(p => p.gender == "男");
            var femaleCount = _activityContext.participants.Count(p => p.gender == "女");
            var total = maleCount + femaleCount;

            if (total == 0) return Ok(new { male = 0, female = 0 });

            return Ok(new
            {
                male = Math.Round((double)maleCount / total * 100, 1),
                female = Math.Round((double)femaleCount / total * 100, 1)
            });
        }
        //取得 feedback 中有回饋感受的比例
        //這個 API 計算 feedback_text 不為空的比例
        [HttpGet("FeedbackResponseRate")]
        public IActionResult GetFeedbackResponseRate()
        {
            var totalCount = _activityContext.feedback.Count();
            var respondedCount = _activityContext.feedback.Count(f => !string.IsNullOrWhiteSpace(f.feedback_text));

            if (totalCount == 0) return Ok(new { responded = 0, noResponse = 0 });

            return Ok(new
            {
                responded = Math.Round((double)respondedCount / totalCount * 100, 1),
                noResponse = Math.Round((double)(totalCount - respondedCount) / totalCount * 100, 1)
            });
        }
        //取得 color_preferences 中使用 balloon = 是 的比例
        //這個 API 計算有使用點點貼的比例
        [HttpGet("BalloonUsageRate")]
        public IActionResult GetBalloonUsageRate()
        {
            var totalCount = _activityContext.color_preferences.Count();
            var balloonYesCount = _activityContext.color_preferences.Count(cp => cp.balloon == "是");

            if (totalCount == 0) return Ok(new { used = 0, notUsed = 0 });

            return Ok(new
            {
                used = Math.Round((double)balloonYesCount / totalCount * 100, 1),
                notUsed = Math.Round((double)(totalCount - balloonYesCount) / totalCount * 100, 1)
            });
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

        // GetExhibitionData - 返回展覽數據以便堆疊條圖使用
        [HttpGet("GetExhibitionData")]
        public IActionResult GetExhibitionData()
        {
            var exhibitionData = _activityContext.exhibition
                .GroupBy(e => e.colorGroup)
                .Select(g => new
                {
                    ColorGroup = g.Key,
                    Red = g.Count(e => e.color == "紅"),
                    Orange = g.Count(e => e.color == "橙"),
                    Yellow = g.Count(e => e.color == "黃"),
                    Green = g.Count(e => e.color == "綠"),
                    Blue = g.Count(e => e.color == "藍"),
                    Indigo = g.Count(e => e.color == "靛"),
                    Purple = g.Count(e => e.color == "紫")
                })
                .ToList();

            return Ok(exhibitionData);
        }

        // 取得 edusideblock 資訊
        [HttpGet("GetEduSideBlockData")]
        public IActionResult GetEduSideBlockData()
        {
            var edusideblockData = _activityContext.edusideblock
                .Select(e => new
                {
                    e.ColumnTitle,
                    e.StartDate,
                    e.LastUsedDate
                })
                .ToList();

            return Ok(edusideblockData);
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

        // 追加的 HttpPost - Submit the exhibition survey data
        [HttpPost("SubmitExhibition")]
        public async Task<IActionResult> SubmitExhibition([FromBody] ExhibitionDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.userId))
            {
                return BadRequest("Invalid form data");
            }

            // 檢查是否已經提交過
            var existingExhibition = await _activityContext.exhibition
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

            _activityContext.exhibition.Add(exhibition);
            await _activityContext.SaveChangesAsync();

            return Ok(new { message = "Survey submitted successfully!" });
        }

    }
}
