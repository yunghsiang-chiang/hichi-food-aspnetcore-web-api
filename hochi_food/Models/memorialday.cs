using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class memorialday
{
    public string md_id { get; set; } = null!;

    public string? md_uid { get; set; }

    public string md_title { get; set; } = null!;

    public string? md_content { get; set; }

    public sbyte md_status { get; set; }

    public string md_cdate { get; set; } = null!;

    public string md_cname { get; set; } = null!;

    public string md_udate { get; set; } = null!;

    public string md_uname { get; set; } = null!;

    public int md_imp { get; set; }

    public int md_impuser { get; set; }

    public string? md_file1 { get; set; }

    public string? md_file2 { get; set; }

    public string? md_file3 { get; set; }

    public string? md_file4 { get; set; }

    public string? md_file5 { get; set; }

    public string md_category { get; set; } = null!;

    public short? md_y { get; set; }
}
