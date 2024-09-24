namespace hochi_food.Dtos
{
    public class permissions_inforDTO
    {
        /// <summary>
        /// 角色的名稱，例如「HR」、「管理者」、「員工」
        /// </summary>
        public string role_name { get; set; } = null!;

        /// <summary>
        /// 記錄角色擁有的訪問權限，以 JSON 格式儲存方便解析
        /// </summary>
        public string permissions { get; set; } = null!;
    }
}
