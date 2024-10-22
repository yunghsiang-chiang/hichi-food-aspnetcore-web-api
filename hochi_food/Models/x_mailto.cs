using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_mailto
{
    public string mt_id { get; set; } = null!;

    public string mt_mfid { get; set; } = null!;

    public string mt_uid { get; set; } = null!;

    public int mt_status { get; set; }

    public string mt_cdate { get; set; } = null!;

    public string mt_checkdate { get; set; } = null!;

    public string mt_uname { get; set; } = null!;

    public int mt_ischeck { get; set; }
}
