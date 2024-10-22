using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class growthmatrix
{
    public string gm_id { get; set; } = null!;

    public string gm_uid { get; set; } = null!;

    public string gm_content { get; set; } = null!;

    public int gm_status { get; set; }

    public string gm_cdate { get; set; } = null!;

    public string gm_cname { get; set; } = null!;

    public string gm_udate { get; set; } = null!;

    public string gm_uname { get; set; } = null!;

    public string gm_recorddate { get; set; } = null!;

    public int gm_imp { get; set; }

    public string gm_title { get; set; } = null!;

    public string? gm_file1 { get; set; }

    public string? gm_file2 { get; set; }

    public string? gm_file3 { get; set; }

    public int? gm_impuser { get; set; }

    public sbyte? gm_category { get; set; }
}
