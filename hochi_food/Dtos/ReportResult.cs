namespace hochi_food.Dtos
{
    public class ReportResult
    {
        public string label { get; set; } // X 軸欄位
        public int value { get; set; }    // 計算結果 (COUNT, SUM, AVG, MAX, MIN)
    }

}
