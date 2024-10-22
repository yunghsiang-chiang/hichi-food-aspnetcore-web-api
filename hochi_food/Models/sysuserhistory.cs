using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sysuserhistory
{
    public long uh_id { get; set; }

    public string uh_uid { get; set; } = null!;

    public string uh_type { get; set; } = null!;

    public string uh_udate { get; set; } = null!;

    public string uh_uname { get; set; } = null!;

    public string uh_cdate { get; set; } = null!;

    public string uh_cname { get; set; } = null!;

    public string uh_begdate { get; set; } = null!;

    public string? uh_enddate { get; set; }

    public string? uh_content1 { get; set; }

    public string? uh_content2 { get; set; }

    public string? uh_notes { get; set; }
}
