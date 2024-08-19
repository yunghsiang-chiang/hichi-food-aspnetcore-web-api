namespace hochi_food.Dtos
{
    public class purchase_DTO
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
        /// 活動期間
        /// </summary>
        public string during_the_activity { get; set; } = null!;

        /// <summary>
        /// 菜色清單
        /// </summary>
        public string? dishes_id_str { get; set; }
    }
}
