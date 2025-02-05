using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTeamTransfer
{
    public int HID { get; set; }

    public string? HOriginTeamID { get; set; }

    public string? HTargetTeamID { get; set; }

    public string? HReason { get; set; }

    public string? HVerifyNum { get; set; }

    public string? HApplicant { get; set; }

    public string? HApplyTime { get; set; }

    public string? HVerifyTime { get; set; }

    public int? HVerifyStatus { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
