namespace hochi_food.Dtos
{
    /// <summary>
    /// 食材單位表
    /// </summary>
    public class ingredients_unitDTO
    {
        /// <summary>
        /// 單位中文稱呼
        /// </summary>
        public string unit_chinese { get; set; } = null!;

        /// <summary>
        /// 單位英文稱呼
        /// </summary>
        public string unit_english { get; set; } = null!;

        /// <summary>
        /// 單位類型
        /// </summary>
        public string unit_type { get; set; } = null!;

        /// <summary>
        /// 單位說明
        /// </summary>
        public string unit_description { get; set; } = null!;
    }
}
