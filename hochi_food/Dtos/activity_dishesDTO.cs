namespace hochi_food.Dtos
{
    public class activity_dishesDTO
    {
        /// <summary>
        /// 活動名稱
        /// </summary>
        public string activity_name { get; set; } = null!;

        /// <summary>
        /// 活動日期
        /// </summary>
        public string activity_date { get; set; }

        /// <summary>
        /// 餐別
        /// </summary>
        public string meal_type { get; set; } = null!;

        /// <summary>
        /// 菜品編號
        /// </summary>
        public string dishes_id { get; set; } = null!;

        /// <summary>
        /// 菜品名稱
        /// </summary>
        public string dishes_name { get; set; } = null!;

        /// <summary>
        /// 菜品類型
        /// </summary>
        public string dishes_type { get; set; } = null!;
    }
}
