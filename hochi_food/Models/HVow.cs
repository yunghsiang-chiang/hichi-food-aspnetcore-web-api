using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HVow
{
    public int HID { get; set; }

    public int HMemberID { get; set; }

    public int HVowType { get; set; }

    public int? HMVTimesPerWeek { get; set; }

    public string HVowContent { get; set; } = null!;

    public DateOnly? HNextAuditDate { get; set; }

    public int HStatus { get; set; }

    public string HCreate { get; set; } = null!;

    public DateTime HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }

    public string? HVowCancelReason { get; set; }

    public string? HVowCancelBy { get; set; }

    public DateTime? HVowCancelDT { get; set; }
}
