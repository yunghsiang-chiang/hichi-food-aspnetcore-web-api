using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class reportreply
{
    public string rr_id { get; set; } = null!;

    public string rr_rid { get; set; } = null!;

    public string rr_uid { get; set; } = null!;

    public string rr_content { get; set; } = null!;

    public sbyte rr_status { get; set; }

    public string rr_cdate { get; set; } = null!;

    public string rr_cname { get; set; } = null!;

    public string rr_udate { get; set; } = null!;

    public string rr_uname { get; set; } = null!;

    public string? rr_file1 { get; set; }

    public string? rr_file2 { get; set; }

    public string? rr_file3 { get; set; }

    public string? rr_parent { get; set; }

    public string? rr_no { get; set; }
}
