using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class alms
{
    public string a_id { get; set; } = null!;

    public string a_uid { get; set; } = null!;

    public string a_cid { get; set; } = null!;

    public string a_type { get; set; } = null!;

    public string a_content { get; set; } = null!;

    public string a_object { get; set; } = null!;

    public int a_money { get; set; }

    public sbyte a_status { get; set; }

    public string a_cdate { get; set; } = null!;

    public string a_cname { get; set; } = null!;

    public string a_udate { get; set; } = null!;

    public string a_uname { get; set; } = null!;

    public string a_rel { get; set; } = null!;

    public string? a_donateitem { get; set; }
}
