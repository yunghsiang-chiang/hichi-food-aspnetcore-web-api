using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sopfile
{
    public string sf_id { get; set; } = null!;

    public string sf_sid { get; set; } = null!;

    public sbyte? sf_order { get; set; }

    public string sf_name { get; set; } = null!;

    public string sf_desc { get; set; } = null!;

    public sbyte sf_status { get; set; }

    public string sf_cdate { get; set; } = null!;

    public string sf_cname { get; set; } = null!;

    public string sf_udate { get; set; } = null!;

    public string sf_uname { get; set; } = null!;
}
