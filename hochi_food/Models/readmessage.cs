using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class readmessage
{
    public long rm_id { get; set; }

    public string rm_funcname { get; set; } = null!;

    public string rm_funcid { get; set; } = null!;

    public string rm_uid { get; set; } = null!;

    public string rm_cdate { get; set; } = null!;

    public string rm_cname { get; set; } = null!;
}
