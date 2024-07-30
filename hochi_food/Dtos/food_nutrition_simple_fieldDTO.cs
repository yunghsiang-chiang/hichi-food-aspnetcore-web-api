namespace hochi_food.Dtos
{
    public class food_nutrition_simple_fieldDTO
    {
        public string 樣品編號 { get; set; } = null!;

        public string 食品分類 { get; set; } = null!;

        public string 樣品名稱 { get; set; } = null!;

        public string? 俗名 { get; set; }

        public string? 內容物描述 { get; set; }
    }
}
