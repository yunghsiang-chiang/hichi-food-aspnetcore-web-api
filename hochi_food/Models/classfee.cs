using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class classfee
{
    public string cf_id { get; set; } = null!;

    public string cf_cid { get; set; } = null!;

    public int cf_type { get; set; }

    public string cf_item { get; set; } = null!;

    public int cf_fee { get; set; }

    public string? cf_desc { get; set; }

    public sbyte cf_status { get; set; }

    public string? cf_cdate { get; set; }

    public string? cf_cname { get; set; }

    public string? cf_udate { get; set; }

    public string? cf_uname { get; set; }
}
