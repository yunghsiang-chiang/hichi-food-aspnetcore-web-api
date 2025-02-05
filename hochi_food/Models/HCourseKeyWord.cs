using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseKeyWord
{
    public int HID { get; set; }

    public string? HKeyword { get; set; }

    public string? HRemark { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HSort { get; set; }
}
