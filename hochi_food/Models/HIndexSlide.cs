using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HIndexSlide
{
    public int HID { get; set; }

    public string? HTitle { get; set; }

    public string? HLink { get; set; }

    public string? HIMG { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
