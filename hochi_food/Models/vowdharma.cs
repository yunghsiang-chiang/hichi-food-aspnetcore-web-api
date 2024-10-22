using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class vowdharma
{
    public string vd_id { get; set; } = null!;

    public string vd_uid { get; set; } = null!;

    public string vd_system { get; set; } = null!;

    public string vd_vdate { get; set; } = null!;

    public string vd_class { get; set; } = null!;

    public string? vd_cid { get; set; }

    public string vd_place { get; set; } = null!;

    public string? vd_duty { get; set; }

    public string? vd_group { get; set; }

    public string vd_cdate { get; set; } = null!;

    public string vd_cname { get; set; } = null!;

    public string vd_udate { get; set; } = null!;

    public string vd_uname { get; set; } = null!;

    public sbyte? vd_status { get; set; }

    public string? vd_ddate { get; set; }

    public string? vd_convention { get; set; }
}
