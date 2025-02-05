using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HUTaskHistory
{
    public int HID { get; set; }

    public int? HMemberID { get; set; }

    public string? HCDate { get; set; }

    public string? HOld { get; set; }

    public string? HNew { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
