using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class blessedseal
{
    public string bs_id { get; set; } = null!;

    public string bs_uid { get; set; } = null!;

    public string? bs_content { get; set; }

    public sbyte bs_status { get; set; }

    public string bs_cdate { get; set; } = null!;

    public string bs_cname { get; set; } = null!;

    public string bs_udate { get; set; } = null!;

    public string bs_uname { get; set; } = null!;

    public string bs_recorddate { get; set; } = null!;

    public int bs_imp { get; set; }

    public string bs_title { get; set; } = null!;

    public string? bs_file1 { get; set; }

    public string? bs_file2 { get; set; }

    public string? bs_file3 { get; set; }

    public int bs_impuser { get; set; }

    public int bs_no { get; set; }

    public string? bs_url { get; set; }

    public sbyte bs_category { get; set; }

    public sbyte? bs_iscurrent { get; set; }

    public string bs_cid { get; set; } = null!;

    public string? bs_applydate { get; set; }

    public int? bs_apply { get; set; }
}
