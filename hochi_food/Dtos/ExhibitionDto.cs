namespace hochi_food.Dtos
{
    public class ExhibitionDto
    {
        public string userId { get; set; } = null!;
        public string colorGroup { get; set; } = null!;
        public string color { get; set; } = null!;
        public bool IsAttendance { get; set; }
        public DateTime attendanceDate { get; set; }
    }
}
