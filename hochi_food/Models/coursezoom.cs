using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class coursezoom
{
    public string cz_id { get; set; } = null!;

    public string cz_cid { get; set; } = null!;

    public string cz_line1 { get; set; } = null!;

    public string? cz_line2 { get; set; }

    public string cz_cdate { get; set; } = null!;

    public string cz_cname { get; set; } = null!;

    public string cz_udate { get; set; } = null!;

    public string cz_uname { get; set; } = null!;

    public sbyte cz_status { get; set; }

    public string cz_date { get; set; } = null!;

    public string? cz_desc { get; set; }
}
