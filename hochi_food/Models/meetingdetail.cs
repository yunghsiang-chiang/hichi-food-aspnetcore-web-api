using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class meetingdetail
{
    public string md_id { get; set; } = null!;

    public string md_mid { get; set; } = null!;

    public string md_title { get; set; } = null!;

    public string? md_content { get; set; }

    public sbyte md_category { get; set; }

    public sbyte md_status { get; set; }

    public string? md_file1 { get; set; }

    public string? md_file1desc { get; set; }

    public string? md_file2 { get; set; }

    public string? md_file2desc { get; set; }

    public string? md_file3 { get; set; }

    public string? md_file3desc { get; set; }

    public string md_cdate { get; set; } = null!;

    public string md_cname { get; set; } = null!;

    public string md_udate { get; set; } = null!;

    public string md_uname { get; set; } = null!;
}
