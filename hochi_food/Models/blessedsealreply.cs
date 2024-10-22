using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class blessedsealreply
{
    public string bsr_id { get; set; } = null!;

    public string bsr_bsid { get; set; } = null!;

    public string bsr_uid { get; set; } = null!;

    public string? bsr_content { get; set; }

    public sbyte bsr_status { get; set; }

    public string bsr_cdate { get; set; } = null!;

    public string bsr_cname { get; set; } = null!;

    public string bsr_udate { get; set; } = null!;

    public string bsr_uname { get; set; } = null!;

    public string? bsr_file1 { get; set; }

    public string? bsr_file2 { get; set; }

    public string? bsr_file3 { get; set; }

    public string bsr_parent { get; set; } = null!;

    public string? bsr_no { get; set; }
}
