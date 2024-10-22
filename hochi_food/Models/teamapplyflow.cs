using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class teamapplyflow
{
    public string taf_id { get; set; } = null!;

    public string taf_taid { get; set; } = null!;

    public string taf_uid { get; set; } = null!;

    public int taf_status { get; set; }

    public string taf_cdate { get; set; } = null!;

    public string taf_cname { get; set; } = null!;

    public string taf_udate { get; set; } = null!;

    public string taf_uname { get; set; } = null!;

    public string? taf_note { get; set; }

    public int? taf_isallow { get; set; }
}
