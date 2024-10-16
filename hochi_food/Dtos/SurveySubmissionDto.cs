using System.ComponentModel.DataAnnotations;

namespace hochi_food.Dtos
{
    public class SurveySubmissionDto
    {
        // 基本資料統計
        [Required]
        public string Gender { get; set; }

        [Required]
        public string AgeRange { get; set; }

        // 社群打卡參與狀況
        [Required]
        public string IsCheckIn { get; set; }

        public string? Platform { get; set; }

        // 顏色選擇統計
        [Required]
        public string MessageBoard { get; set; }

        public string? MessageBoardColor1 { get; set; }

        public string? MessageBoardColor2 { get; set; }

        [Required]
        public string Balloon { get; set; }

        public string? BalloonColor1 { get; set; }

        public string? BalloonColor2 { get; set; }

        // 反饋與觀察
        [Required]
        public string ColorChoice { get; set; }

        public string? ColorChoiceText { get; set; }

        [Required]
        public string Satisfaction { get; set; }

        public string? FeedbackText { get; set; }

        public string? PromoterObservation { get; set; }

        public string? Others { get; set; }
    }
}
