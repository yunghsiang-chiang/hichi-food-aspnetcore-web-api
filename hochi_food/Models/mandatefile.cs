using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class mandatefile
{
    public string mf_id { get; set; } = null!;

    public string mf_mid { get; set; } = null!;

    public string mf_category { get; set; } = null!;

    public string mf_filename { get; set; } = null!;

    public string mf_note { get; set; } = null!;

    public string mf_cdate { get; set; } = null!;

    public string mf_cname { get; set; } = null!;

    public string mf_udate { get; set; } = null!;

    public string mf_uname { get; set; } = null!;
}
