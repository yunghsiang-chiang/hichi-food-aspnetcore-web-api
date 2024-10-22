using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class _class
{
    public string c_id { get; set; } = null!;

    public string c_name { get; set; } = null!;

    public sbyte c_status { get; set; }

    public string c_cdate { get; set; } = null!;

    public string c_cname { get; set; } = null!;

    public string c_udate { get; set; } = null!;

    public string c_uname { get; set; } = null!;

    public sbyte c_type { get; set; }

    public string? c_area { get; set; }

    public sbyte c_category { get; set; }

    public sbyte c_week { get; set; }

    public string? c_weektime { get; set; }

    public string c_begdate { get; set; } = null!;

    public string c_enddate { get; set; } = null!;

    public string c_sbegdate { get; set; } = null!;

    public string c_senddate { get; set; } = null!;

    public sbyte c_ishouse { get; set; }

    public sbyte? c_grstatus { get; set; }

    public string? c_shortname { get; set; }

    public int? c_diffdays { get; set; }

    public string? c_desc { get; set; }

    public sbyte? c_iskeep { get; set; }

    public string? old_class_id { get; set; }
}
