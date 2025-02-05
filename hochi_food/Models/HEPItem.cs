using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HEPItem
{
    public int HID { get; set; }

    public int? HEPType { get; set; }

    public string? HEPItem1 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
