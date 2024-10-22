using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class entourage
{
    public string e_id { get; set; } = null!;

    public string e_uid { get; set; } = null!;

    public string e_content { get; set; } = null!;

    public int e_status { get; set; }

    public string e_cdate { get; set; } = null!;

    public string e_cname { get; set; } = null!;

    public string e_udate { get; set; } = null!;

    public string e_uname { get; set; } = null!;

    public string e_recorddate { get; set; } = null!;

    public int e_imp { get; set; }

    public string e_title { get; set; } = null!;

    public string? e_file1 { get; set; }

    public string? e_file2 { get; set; }

    public string? e_file3 { get; set; }

    public int? e_no { get; set; }
}
