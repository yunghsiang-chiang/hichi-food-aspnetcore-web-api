using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class grpuser
{
    public string gu_id { get; set; } = null!;

    public string gu_gid { get; set; } = null!;

    public string gu_uid { get; set; } = null!;

    public sbyte gu_status { get; set; }

    public string? gu_cdate { get; set; }

    public string? gu_udate { get; set; }

    public string? gu_cname { get; set; }

    public string? gu_uname { get; set; }
}
