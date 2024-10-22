using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class vowverify
{
    public string vv_id { get; set; } = null!;

    public string vv_vid { get; set; } = null!;

    public string vv_uid { get; set; } = null!;

    public string vv_level { get; set; } = null!;

    public string vv_date { get; set; } = null!;

    public sbyte vv_status { get; set; }

    public string? vv_desc { get; set; }

    public string vv_cdate { get; set; } = null!;

    public string vv_cname { get; set; } = null!;

    public string vv_udate { get; set; } = null!;

    public string vv_uname { get; set; } = null!;
}
