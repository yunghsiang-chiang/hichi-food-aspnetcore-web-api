using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class psn_active_sc
{
    public string SC_ID { get; set; } = null!;

    public string DATE { get; set; } = null!;

    public string PSN_ID { get; set; } = null!;

    public int? QTY { get; set; }

    public string? MEMO { get; set; }

    public string? ARRIVE_TIME { get; set; }

    public string? LEFT_TIME { get; set; }

    public int? status { get; set; }

    public string? pas_cdate { get; set; }

    public string? pas_cname { get; set; }

    public string? pas_udate { get; set; }

    public string? pas_uname { get; set; }
}
