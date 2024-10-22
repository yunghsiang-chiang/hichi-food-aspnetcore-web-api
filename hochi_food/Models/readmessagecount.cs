using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class readmessagecount
{
    public long rmc_id { get; set; }

    public string rmc_funcname { get; set; } = null!;

    public string rmc_funcid { get; set; } = null!;

    public string rmc_uid { get; set; } = null!;

    public string rmc_cdate { get; set; } = null!;

    public int rmc_count { get; set; }
}
