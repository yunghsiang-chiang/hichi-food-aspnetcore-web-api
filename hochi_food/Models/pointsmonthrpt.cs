using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class pointsmonthrpt
{
    public string pm_id { get; set; } = null!;

    public string pm_ym { get; set; } = null!;

    public string pm_uid { get; set; } = null!;

    public int pm_pre { get; set; }

    public string pm_lastbuydate { get; set; } = null!;

    public int pm_this { get; set; }

    public int pm_use { get; set; }

    public int pm_eff { get; set; }

    public int pm_remain { get; set; }

    public int pm_remainfee { get; set; }

    public string pm_cdate { get; set; } = null!;

    public string pm_cname { get; set; } = null!;

    public string pm_udate { get; set; } = null!;

    public string pm_uname { get; set; } = null!;
}
