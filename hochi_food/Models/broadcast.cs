using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class broadcast
{
    public string b_id { get; set; } = null!;

    public string b_uid { get; set; } = null!;

    public string b_cname { get; set; } = null!;

    public string b_unitname { get; set; } = null!;

    public string b_content { get; set; } = null!;

    public string b_cdate { get; set; } = null!;

    public int b_status { get; set; }

    public string? b_file1 { get; set; }

    public string? b_file1desc { get; set; }

    public string? b_file2 { get; set; }

    public string? b_file2desc { get; set; }

    public string? b_file3 { get; set; }

    public string? b_file3desc { get; set; }

    public string? b_file4 { get; set; }

    public string? b_file4desc { get; set; }

    public string? b_file5 { get; set; }

    public string? b_file5desc { get; set; }

    public int b_imp { get; set; }

    public string b_udate { get; set; } = null!;

    public string b_uname { get; set; } = null!;

    public string? b_title { get; set; }

    public int b_no { get; set; }

    public string? b_subunitname { get; set; }

    public sbyte? b_istop { get; set; }
}
