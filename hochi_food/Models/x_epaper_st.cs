using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_epaper_st
{
    public string ep_id { get; set; } = null!;

    public string ep_type { get; set; } = null!;

    public int ep_no { get; set; }

    public string ep_catalog { get; set; } = null!;

    public string ep_pdate { get; set; } = null!;

    public string? ep_class { get; set; }

    public string? ep_name { get; set; }

    public string ep_title { get; set; } = null!;

    public string ep_content { get; set; } = null!;

    public string ep_cdate { get; set; } = null!;

    public string ep_cname { get; set; } = null!;

    public int ep_status { get; set; }

    public string ep_udate { get; set; } = null!;

    public string ep_uname { get; set; } = null!;
}
