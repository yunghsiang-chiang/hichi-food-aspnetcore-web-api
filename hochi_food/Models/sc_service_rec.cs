using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sc_service_rec
{
    public string SC_ID_no { get; set; } = null!;

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

    public string? ssr_cdate { get; set; }

    public string? ssr_cname { get; set; }

    public string? ssr_udate { get; set; }

    public string? ssr_uname { get; set; }
}
