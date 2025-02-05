using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseTask
{
    public int HID { get; set; }

    public int? HSystemID { get; set; }

    public int? HGroupID { get; set; }

    public string? HTask { get; set; }

    public string? HTaskContent { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public bool? HReceivable { get; set; }
}
