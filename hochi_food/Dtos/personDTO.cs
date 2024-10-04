namespace hochi_food.Dtos
{
    public class personDTO
    {
        /// <summary>
        /// id
        /// </summary>
        public string person_id { get; set; } = null!;

        /// <summary>
        /// 姓名
        /// </summary>
        public string? person_name { get; set; }
        /// <summary>
        /// 人員類型
        /// </summary>
        public string? person_type { get; set; }
    }
}
