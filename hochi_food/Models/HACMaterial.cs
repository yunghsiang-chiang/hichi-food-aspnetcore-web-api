using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HACMaterial
{
    public int HID { get; set; }

    public string? HCourseID { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public int? HACMClass { get; set; }

    public string? HCMName { get; set; }

    public string? HUP1 { get; set; }

    public string? HUP2 { get; set; }

    public string? HUP3 { get; set; }

    public string? HUP4 { get; set; }

    public string? HUP5 { get; set; }

    public string? HCMLink { get; set; }

    public string? HEIPLink { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
