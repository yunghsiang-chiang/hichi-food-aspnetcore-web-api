using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLogs_HPosition
{
    public int HID { get; set; }

    public string? HContent { get; set; }

    public string? HType { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
