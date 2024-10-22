using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class buycdrecord
{
    public string bcr_id { get; set; } = null!;

    public string bcr_uid { get; set; } = null!;

    public string bcr_cddate { get; set; } = null!;

    public string bcr_applydate { get; set; } = null!;

    public string bcr_points { get; set; } = null!;

    public string bcr_cname { get; set; } = null!;
}
