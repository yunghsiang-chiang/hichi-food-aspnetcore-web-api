using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sc_active_rec
{
    public string SC_ID { get; set; } = null!;

    public string DATE { get; set; } = null!;

    public string? TXT_NAME { get; set; }

    public string? START_TIME { get; set; }

    public string? END_TIME { get; set; }

    public string? LEADER_NAME { get; set; }

    public string? CONTENT { get; set; }

    public string? INPROVE { get; set; }

    public string? REQUEST { get; set; }

    public string? REPLY { get; set; }

    public int? status { get; set; }

    public string? sar_cdate { get; set; }

    public string? sar_cname { get; set; }

    public string? sar_udate { get; set; }

    public string? sar_uname { get; set; }
}
