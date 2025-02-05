using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLeadingCourse_T
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public int? HLCourseID { get; set; }

    public decimal? HDiscount { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }

    public string? HCBatchNum { get; set; }
}
