using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class points
{
    public string p_id { get; set; } = null!;

    public string p_uid { get; set; } = null!;

    public int p_points { get; set; }

    public int p_fee { get; set; }

    public sbyte p_paytype { get; set; }

    public string p_desc { get; set; } = null!;

    public sbyte p_status { get; set; }

    public string p_cdate { get; set; } = null!;

    public string p_cname { get; set; } = null!;

    public string p_udate { get; set; } = null!;

    public string p_uname { get; set; } = null!;

    public string p_paydate { get; set; } = null!;

    public string? p_func { get; set; }

    public string? p_funcid { get; set; }

    public sbyte? p_category { get; set; }

    public string? p_info { get; set; }

    public string? p_linkpay { get; set; }

    public string? p_invoiceno { get; set; }

    public string? p_effdate { get; set; }

    public int? p_subtotal { get; set; }
}
