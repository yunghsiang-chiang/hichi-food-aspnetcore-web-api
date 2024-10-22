using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class blood
{
    public string b_id { get; set; } = null!;

    public string b_cid { get; set; } = null!;

    public string b_uid { get; set; } = null!;

    public int b_no { get; set; }

    public sbyte? b_status { get; set; }

    public string b_cdate { get; set; } = null!;

    public string b_cname { get; set; } = null!;

    public string b_udate { get; set; } = null!;

    public string b_uname { get; set; } = null!;
}
