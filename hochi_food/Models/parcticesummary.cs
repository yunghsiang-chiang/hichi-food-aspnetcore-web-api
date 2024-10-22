using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class parcticesummary
{
    public string ps_id { get; set; } = null!;

    public string ps_pid { get; set; } = null!;

    public string ps_uid { get; set; } = null!;

    public sbyte ps_type { get; set; }

    public string? ps_content { get; set; }

    public sbyte ps_status { get; set; }

    public string ps_cdate { get; set; } = null!;

    public string ps_cname { get; set; } = null!;

    public string ps_udate { get; set; } = null!;

    public string ps_uname { get; set; } = null!;
}
