using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMVowRecord
{
    public int HID { get; set; }

    public int HMVowType { get; set; }

    public DateOnly HMVowDate { get; set; }

    public string HMVowTable { get; set; } = null!;

    public int HMVowTableID { get; set; }

    public string HMVowContent { get; set; } = null!;

    public string? HMVCancelReason { get; set; }

    public int HStatus { get; set; }

    public string HCreate { get; set; } = null!;

    public DateTime HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
