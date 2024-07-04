namespace hochi_food.Dtos
{
    public class activity_searchDTO
    {
        /// <summary>
        /// 活動名稱
        /// </summary>
        public string activity_name { get; set; } = null!;

        /// <summary>
        /// 活動日期
        /// </summary>
        public DateTime activity_date { get; set; }

        /// <summary>
        /// 餐別
        /// </summary>
        public string meal_type { get; set; } = null!;

        /// <summary>
        /// 活動天數
        /// </summary>
        public int? activity_days { get; set; }

        /// <summary>
        /// 活動期間
        /// </summary>
        public string? during_the_activity { get; set; }

        /// <summary>
        /// 最後編輯者
        /// </summary>
        public string? lm_user { get; set; }

    }
}
