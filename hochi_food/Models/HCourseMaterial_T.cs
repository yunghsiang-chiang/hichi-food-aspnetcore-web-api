using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseMaterial_T
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public string HCMName { get; set; } = null!;

    public string? HCMaterial { get; set; }

    public string? HCMLink { get; set; }

    public int? HSort { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }

    public string? HCBatchNum { get; set; }
}
