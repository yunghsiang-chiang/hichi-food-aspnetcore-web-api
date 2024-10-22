using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sopreply
{
    public string sr_id { get; set; } = null!;

    public string sr_sid { get; set; } = null!;

    public string sr_uid { get; set; } = null!;

    public string sr_content { get; set; } = null!;

    public sbyte sr_status { get; set; }

    public string sr_cdate { get; set; } = null!;

    public string sr_cname { get; set; } = null!;

    public string sr_udate { get; set; } = null!;

    public string sr_uname { get; set; } = null!;
}
