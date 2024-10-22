using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class photovideo
{
    public string pv_id { get; set; } = null!;

    public string pv_uid { get; set; } = null!;

    public string? pv_content { get; set; }

    public sbyte pv_status { get; set; }

    public string pv_cdate { get; set; } = null!;

    public string pv_cname { get; set; } = null!;

    public string pv_udate { get; set; } = null!;

    public string pv_uname { get; set; } = null!;

    public string pv_recorddate { get; set; } = null!;

    public int pv_imp { get; set; }

    public string pv_title { get; set; } = null!;

    public string? pv_file1 { get; set; }

    public string? pv_file2 { get; set; }

    public string? pv_file3 { get; set; }

    public int pv_impuser { get; set; }

    public int pv_no { get; set; }

    public string? pv_url { get; set; }

    public sbyte pv_category { get; set; }

    public sbyte? pv_iscurrent { get; set; }

    public string pv_cid { get; set; } = null!;

    public string? pv_applydate { get; set; }

    public int? pv_apply { get; set; }
}
