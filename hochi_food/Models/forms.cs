using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class forms
{
    public string f_id { get; set; } = null!;

    public string f_type { get; set; } = null!;

    public string f_unit { get; set; } = null!;

    public string f_no { get; set; } = null!;

    public string f_title { get; set; } = null!;

    public string? f_desc { get; set; }

    public int f_status { get; set; }

    public string f_filename { get; set; } = null!;

    public string? f_version { get; set; }

    public string f_cdate { get; set; } = null!;

    public string f_cname { get; set; } = null!;

    public string f_udate { get; set; } = null!;

    public string f_uname { get; set; } = null!;
}
