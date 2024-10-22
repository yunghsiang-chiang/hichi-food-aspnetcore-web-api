using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class progress
{
    public string p_id { get; set; } = null!;

    public string p_title { get; set; } = null!;

    public string p_content { get; set; } = null!;

    public sbyte p_status { get; set; }

    public string p_cdate { get; set; } = null!;

    public string p_cname { get; set; } = null!;

    public string p_udate { get; set; } = null!;

    public string p_uname { get; set; } = null!;

    public string p_category { get; set; } = null!;
}
