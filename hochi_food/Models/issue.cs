using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class issue
{
    public string i_id { get; set; } = null!;

    public string? i_uid { get; set; }

    public string i_email { get; set; } = null!;

    public int i_type { get; set; }

    public string i_content { get; set; } = null!;

    public string i_cdate { get; set; } = null!;

    public string i_cname { get; set; } = null!;

    public string i_udate { get; set; } = null!;

    public string i_uname { get; set; } = null!;

    public int i_status { get; set; }

    public string i_rdate { get; set; } = null!;

    public string? i_rname { get; set; }

    public string? i_rcontent { get; set; }

    public string i_title { get; set; } = null!;
}
