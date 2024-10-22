using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_courseuser
{
    public string cu_id { get; set; } = null!;

    public string cu_cid { get; set; } = null!;

    public string cu_uid { get; set; } = null!;

    public string? cu_cdate { get; set; }

    public string? cu_cname { get; set; }

    public string? cu_udate { get; set; }

    public string? cu_uname { get; set; }

    public int? cu_type { get; set; }

    public int cu_sign { get; set; }

    public string? cu_signtime { get; set; }
}
