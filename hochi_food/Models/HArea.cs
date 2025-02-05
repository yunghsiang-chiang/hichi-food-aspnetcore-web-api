using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HArea
{
    public int HID { get; set; }

    public int? HLAreaID { get; set; }

    public string? HArea1 { get; set; }

    public string? HARange { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HSort { get; set; }
}
