using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class classhouse
{
    public string ch_id { get; set; } = null!;

    public string ch_cid { get; set; } = null!;

    public string ch_uid { get; set; } = null!;

    public string ch_sdate { get; set; } = null!;

    public sbyte ch_status { get; set; }

    public string? ch_cdate { get; set; }

    public string? ch_cname { get; set; }

    public string? ch_udate { get; set; }

    public string? ch_uname { get; set; }
}
