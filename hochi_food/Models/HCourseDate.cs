using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseDate
{
    public int HID { get; set; }

    public string? HCBatchNum { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public DateOnly? HDate { get; set; }

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
