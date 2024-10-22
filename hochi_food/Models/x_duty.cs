using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_duty
{
    public long d_id { get; set; }

    public string d_cid { get; set; } = null!;

    public string d_date { get; set; } = null!;

    public string d_aid { get; set; } = null!;

    public string d_aname { get; set; } = null!;

    public string d_uid { get; set; } = null!;

    public int d_status { get; set; }

    public string? d_cdate { get; set; }

    public string? d_cname { get; set; }

    public string? d_udate { get; set; }

    public string? d_uname { get; set; }

    public string? d_note { get; set; }
}
