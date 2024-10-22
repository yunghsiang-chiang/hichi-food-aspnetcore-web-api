using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class teamoperation
{
    public string to_id { get; set; } = null!;

    public int to_no { get; set; }

    public string to_taid { get; set; } = null!;

    public string to_cdate { get; set; } = null!;

    public string to_cname { get; set; } = null!;

    public string to_udate { get; set; } = null!;

    public string to_uname { get; set; } = null!;

    public string to_member { get; set; } = null!;

    public string? to_content { get; set; }

    public int to_status { get; set; }

    public string? to_enddate { get; set; }

    public string to_aid { get; set; } = null!;

    public string? to_dharma { get; set; }

    public string? to_team { get; set; }

    public string? to_subject { get; set; }

    public int? to_iscombine { get; set; }

    public string? to_begdate { get; set; }

    public int? to_imp { get; set; }

    public string? to_ruid { get; set; }

    public string? to_rname { get; set; }

    public string? to_reply { get; set; }

    public string? to_rdate { get; set; }

    public string? to_file1 { get; set; }
}
