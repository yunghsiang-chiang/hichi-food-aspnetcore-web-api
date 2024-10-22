using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class report
{
    public string r_id { get; set; } = null!;

    public string r_uid { get; set; } = null!;

    public string r_title { get; set; } = null!;

    public string r_content { get; set; } = null!;

    public sbyte r_status { get; set; }

    public string r_cdate { get; set; } = null!;

    public string r_cname { get; set; } = null!;

    public string r_udate { get; set; } = null!;

    public string r_uname { get; set; } = null!;

    public int r_imp { get; set; }

    public int r_impuser { get; set; }

    public string? r_file1 { get; set; }

    public string? r_file2 { get; set; }

    public string? r_file3 { get; set; }

    public string? r_no { get; set; }

    public string r_category2 { get; set; } = null!;

    public sbyte? r_type { get; set; }

    public sbyte? r_category1 { get; set; }
}
