using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_coursesignin
{
    public int cs_id { get; set; }

    public int cs_sign { get; set; }

    public string? cs_signtime { get; set; }

    public string? cs_cdate { get; set; }

    public string? cs_cname { get; set; }
}
