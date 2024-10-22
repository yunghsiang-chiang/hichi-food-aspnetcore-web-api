using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class rule
{
    public string r_id { get; set; } = null!;

    public string r_uid { get; set; } = null!;

    public string r_cname { get; set; } = null!;

    public string r_unitname { get; set; } = null!;

    public string r_content { get; set; } = null!;

    public string r_cdate { get; set; } = null!;

    public int r_status { get; set; }

    public int r_imp { get; set; }

    public string r_udate { get; set; } = null!;

    public string r_uname { get; set; } = null!;

    public string r_title { get; set; } = null!;

    public int r_no { get; set; }

    public string r_parent { get; set; } = null!;

    public string r_version { get; set; } = null!;

    public string r_desc { get; set; } = null!;

    public string r_pdate { get; set; } = null!;
}
