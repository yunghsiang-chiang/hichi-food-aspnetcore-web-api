using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HActivity
{
    public int HID { get; set; }

    public string? HTitle { get; set; }

    public int? HClassID { get; set; }

    public string? HContent { get; set; }

    public string? HImage { get; set; }

    public string? HVideoLink { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
