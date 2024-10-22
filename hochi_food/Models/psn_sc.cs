using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class psn_sc
{
    public string SC_ID_no { get; set; } = null!;

    public string DATE { get; set; } = null!;

    public string PSN_ID { get; set; } = null!;

    public int? QTY { get; set; }

    public string? MEMO { get; set; }

    public string ARRIVE_TIME { get; set; } = null!;

    public string LEFT_TIME { get; set; } = null!;

    public int status { get; set; }

    public string ps_cdate { get; set; } = null!;

    public string ps_cname { get; set; } = null!;

    public string ps_udate { get; set; } = null!;

    public string ps_uname { get; set; } = null!;
}
