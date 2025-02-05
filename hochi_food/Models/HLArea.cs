using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLArea
{
    public int HID { get; set; }

    public string? HLArea1 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HALeaderID { get; set; }

    public int? HSort { get; set; }
}
