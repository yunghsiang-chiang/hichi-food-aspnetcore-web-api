using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTeamTVerifyLog
{
    public int HID { get; set; }

    public int? HTeamTransferID { get; set; }

    public string? HSignName { get; set; }

    public string? HVDate { get; set; }

    public int? HVResult { get; set; }

    public string? HVOpinion { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
