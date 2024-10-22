using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class growthrecord_copy1
{
    public string gr_id { get; set; } = null!;

    public string gr_uid { get; set; } = null!;

    public string gr_cid { get; set; } = null!;

    public int gr_type { get; set; }

    public string gr_content1 { get; set; } = null!;

    public int gr_status { get; set; }

    public string gr_cdate { get; set; } = null!;

    public string gr_cname { get; set; } = null!;

    public string gr_udate { get; set; } = null!;

    public string gr_uname { get; set; } = null!;

    public string gr_recorddate { get; set; } = null!;

    public string? gr_content2 { get; set; }

    public int gr_imp { get; set; }

    public string gr_title { get; set; } = null!;

    public string? gr_file1 { get; set; }

    public string? gr_file2 { get; set; }

    public string? gr_file3 { get; set; }

    public string gr_no { get; set; } = null!;

    public string gr_dharma { get; set; } = null!;

    public string gr_dharmaname { get; set; } = null!;

    public sbyte gr_impuser { get; set; }

    public sbyte gr_category { get; set; }

    public sbyte gr_grid { get; set; }

    public string? gr_label { get; set; }

    public sbyte? gr_grid2 { get; set; }

    public string? gr_lid { get; set; }

    public string? gr_lrid { get; set; }
}
