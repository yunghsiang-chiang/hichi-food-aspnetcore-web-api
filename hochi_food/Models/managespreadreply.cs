using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class managespreadreply
{
    public string msr_id { get; set; } = null!;

    public string msr_bsid { get; set; } = null!;

    public string msr_uid { get; set; } = null!;

    public string? msr_content { get; set; }

    public sbyte msr_status { get; set; }

    public string msr_cdate { get; set; } = null!;

    public string msr_cname { get; set; } = null!;

    public string msr_udate { get; set; } = null!;

    public string msr_uname { get; set; } = null!;

    public string? msr_file1 { get; set; }

    public string? msr_file2 { get; set; }

    public string? msr_file3 { get; set; }

    public string msr_parent { get; set; } = null!;

    public string? msr_no { get; set; }
}
