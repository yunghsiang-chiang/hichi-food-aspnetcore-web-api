using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class entouragereply
{
    public string er_id { get; set; } = null!;

    public string er_eid { get; set; } = null!;

    public string er_uid { get; set; } = null!;

    public string er_content { get; set; } = null!;

    public int er_status { get; set; }

    public string er_cdate { get; set; } = null!;

    public string er_cname { get; set; } = null!;

    public string er_udate { get; set; } = null!;

    public string er_uname { get; set; } = null!;

    public string? er_file1 { get; set; }

    public string? er_file2 { get; set; }

    public string? er_file3 { get; set; }
}
