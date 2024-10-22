using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class eipprogress
{
    public string ep_id { get; set; } = null!;

    public string ep_title { get; set; } = null!;

    public string ep_content { get; set; } = null!;

    public sbyte ep_status { get; set; }

    public string ep_cdate { get; set; } = null!;

    public string ep_cname { get; set; } = null!;

    public string ep_udate { get; set; } = null!;

    public string ep_uname { get; set; } = null!;
}
