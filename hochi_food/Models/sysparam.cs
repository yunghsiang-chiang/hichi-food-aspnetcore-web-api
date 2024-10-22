using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sysparam
{
    public string sp_id { get; set; } = null!;

    public string? sp_title { get; set; }

    public string? sp_value { get; set; }

    public string? sp_unit { get; set; }

    public string? sp_desc { get; set; }

    public string? sp_cdate { get; set; }

    public string? sp_cname { get; set; }

    public string? sp_udate { get; set; }

    public string? sp_uname { get; set; }
}
