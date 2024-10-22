using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sop
{
    public string s_id { get; set; } = null!;

    public string s_uid { get; set; } = null!;

    public sbyte s_category { get; set; }

    public int s_no { get; set; }

    public string s_title { get; set; } = null!;

    public string s_content { get; set; } = null!;

    public string s_pdate { get; set; } = null!;

    public int s_impuser { get; set; }

    public int s_imp { get; set; }

    public sbyte s_status { get; set; }

    public string s_cdate { get; set; } = null!;

    public string s_cname { get; set; } = null!;

    public string s_udate { get; set; } = null!;

    public string s_uname { get; set; } = null!;
}
