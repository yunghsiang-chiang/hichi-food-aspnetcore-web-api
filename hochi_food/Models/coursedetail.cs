using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class coursedetail
{
    public string cd_id { get; set; } = null!;

    public int cd_type { get; set; }

    public int cd_order { get; set; }

    public string cd_title { get; set; } = null!;

    public string? cd_desc { get; set; }

    public int cd_status { get; set; }

    public string cd_cdate { get; set; } = null!;

    public string cd_cname { get; set; } = null!;

    public string cd_udate { get; set; } = null!;

    public string cd_uname { get; set; } = null!;

    public string cd_cid { get; set; } = null!;

    public int? cd_week { get; set; }

    public string cd_link { get; set; } = null!;

    public string? cd_coursedate { get; set; }

    public string? cd_weekname { get; set; }

    public string? cd_category { get; set; }
}
