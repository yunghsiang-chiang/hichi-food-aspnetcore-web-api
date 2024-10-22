using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class courseatendence
{
    public string ca_id { get; set; } = null!;

    public string ca_cid { get; set; } = null!;

    public string ca_uid { get; set; } = null!;

    public sbyte ca_type { get; set; }

    public sbyte ca_duty { get; set; }

    public string ca_begdate { get; set; } = null!;

    public string ca_enddate { get; set; } = null!;

    public string ca_onlydate { get; set; } = null!;

    public string? ca_desc { get; set; }

    public sbyte ca_status { get; set; }

    public string ca_cdate { get; set; } = null!;

    public string ca_cname { get; set; } = null!;

    public string ca_udate { get; set; } = null!;

    public string ca_uname { get; set; } = null!;

    public sbyte ca_iskeep { get; set; }
}
