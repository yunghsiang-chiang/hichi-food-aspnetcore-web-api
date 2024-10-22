using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class managespread
{
    public string ms_id { get; set; } = null!;

    public string ms_uid { get; set; } = null!;

    public string? ms_content { get; set; }

    public sbyte ms_status { get; set; }

    public string ms_cdate { get; set; } = null!;

    public string ms_cname { get; set; } = null!;

    public string ms_udate { get; set; } = null!;

    public string ms_uname { get; set; } = null!;

    public string ms_recorddate { get; set; } = null!;

    public int ms_imp { get; set; }

    public string ms_title { get; set; } = null!;

    public string? ms_file1 { get; set; }

    public string? ms_file2 { get; set; }

    public string? ms_file3 { get; set; }

    public int ms_impuser { get; set; }

    public int ms_no { get; set; }

    public string? ms_url { get; set; }

    public short ms_category { get; set; }

    public sbyte? ms_iscurrent { get; set; }

    public string ms_cid { get; set; } = null!;

    public int ms_reply { get; set; }

    public int ms_q { get; set; }
}
