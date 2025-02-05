using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCourseKeyWord
{
    public int HID { get; set; }

    public int? HKeyWordID { get; set; }

    public string? HSKeyword { get; set; }

    public string? HRemark { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
