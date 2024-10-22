using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class partner
{
    public string p_id { get; set; } = null!;

    public string p_aid { get; set; } = null!;

    public string p_uid1 { get; set; } = null!;

    public string? p_uname1 { get; set; }

    public sbyte p_level1 { get; set; }

    public string p_uid2 { get; set; } = null!;

    public string? p_uname2 { get; set; }

    public sbyte p_level2 { get; set; }

    public string p_effdate { get; set; } = null!;

    public string p_expdate { get; set; } = null!;

    public string p_cdate { get; set; } = null!;

    public string p_cname { get; set; } = null!;

    public string p_udate { get; set; } = null!;

    public string p_uname { get; set; } = null!;

    public string p_effreason { get; set; } = null!;

    public string p_expreason { get; set; } = null!;

    public int p_no { get; set; }

    public string p_tid { get; set; } = null!;

    public string? p_as { get; set; }

    public string? p_ts { get; set; }

    public sbyte? p_status { get; set; }
}
