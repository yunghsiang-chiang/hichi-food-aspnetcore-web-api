using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourse_Class
{
    public int HID { get; set; }

    public string? HCourseName { get; set; }

    public string? HPicture { get; set; }

    public int? HType { get; set; }

    public bool? HShowIndex { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
