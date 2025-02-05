using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPlace
{
    public int HID { get; set; }

    public string? HAreaID { get; set; }

    public string? HPlaceName { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
