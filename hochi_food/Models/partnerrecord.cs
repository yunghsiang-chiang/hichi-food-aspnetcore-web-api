using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class partnerrecord
{
    public string pr_id { get; set; } = null!;

    public string pr_pid { get; set; } = null!;

    public string pr_recorddate { get; set; } = null!;

    public sbyte pr_support1 { get; set; }

    public string? pr_record1 { get; set; }

    public sbyte pr_support2 { get; set; }

    public string? pr_record2 { get; set; }

    public string? pr_ts { get; set; }

    public string? pr_as { get; set; }

    public string pr_cdate { get; set; } = null!;

    public string pr_cname { get; set; } = null!;

    public string pr_udate { get; set; } = null!;

    public string pr_uname { get; set; } = null!;

    public sbyte pr_status { get; set; }

    public string? pr_laoshi { get; set; }
}
