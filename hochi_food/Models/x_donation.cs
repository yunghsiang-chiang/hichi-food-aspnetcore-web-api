using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_donation
{
    public string d_id { get; set; } = null!;

    public string? d_uid { get; set; }

    public string d_donateitem { get; set; } = null!;

    public string d_title { get; set; } = null!;

    public string d_type { get; set; } = null!;

    public string d_ddate { get; set; } = null!;

    public string? d_bank { get; set; }

    public string? d_bankno { get; set; }

    public int? d_money { get; set; }

    public string? d_note { get; set; }

    public string d_cdate { get; set; } = null!;

    public string d_cname { get; set; } = null!;

    public string d_udate { get; set; } = null!;

    public string d_uname { get; set; } = null!;

    public string d_handled { get; set; } = null!;

    public int? d_status { get; set; }

    public string d_tempno { get; set; } = null!;

    public int d_isprint { get; set; }
}
