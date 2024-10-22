using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class parctice
{
    public string p_id { get; set; } = null!;

    public string p_uid { get; set; } = null!;

    public string p_category { get; set; } = null!;

    public sbyte p_type { get; set; }

    public string p_recorddate { get; set; } = null!;

    public string? p_content { get; set; }

    public sbyte p_status { get; set; }

    public string p_cdate { get; set; } = null!;

    public string p_cname { get; set; } = null!;

    public string p_udate { get; set; } = null!;

    public string p_uname { get; set; } = null!;

    public int p_imp { get; set; }

    public int p_impuser { get; set; }

    public string? p_progress { get; set; }
}
