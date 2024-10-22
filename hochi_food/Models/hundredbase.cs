using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class hundredbase
{
    public string hb_id { get; set; } = null!;

    public string hb_uid { get; set; } = null!;

    public string hb_hbqid { get; set; } = null!;

    public string hb_begdate { get; set; } = null!;

    public string hb_expdate { get; set; } = null!;

    public string? hb_enddate { get; set; }

    public string? hb_notes { get; set; }

    public sbyte hb_status { get; set; }

    public string hb_cdate { get; set; } = null!;

    public string hb_cname { get; set; } = null!;

    public string hb_udate { get; set; } = null!;

    public string hb_uname { get; set; } = null!;
}
