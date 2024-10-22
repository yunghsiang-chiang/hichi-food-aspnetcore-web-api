using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class exhibition
{
    public string userId { get; set; } = null!;

    public string colorGroup { get; set; } = null!;

    public string color { get; set; } = null!;

    public bool IsAttendance { get; set; }

    public DateTime attendanceDate { get; set; }
}
