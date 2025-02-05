using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseVerifyList
{
    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public string? HPlaceName { get; set; }

    public int HStatus { get; set; }

    public int? HVerifyStatus { get; set; }

    public string? Applicant { get; set; }

    public string? HID { get; set; }

    public string? HSave { get; set; }

    public string? HApplyTime { get; set; }

    public string? HVerifyTime { get; set; }
}
