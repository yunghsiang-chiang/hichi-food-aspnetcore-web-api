using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class classmember
{
    public string cm_id { get; set; } = null!;

    public string cm_cid { get; set; } = null!;

    public string? cm_type { get; set; }

    public string cm_uid { get; set; } = null!;

    public sbyte cm_status { get; set; }

    public string cm_cdate { get; set; } = null!;

    public string cm_cname { get; set; } = null!;

    public string cm_udate { get; set; } = null!;

    public string cm_uname { get; set; } = null!;

    public string? cm_fee { get; set; }

    public string? cm_area { get; set; }

    public string? cm_desc { get; set; }

    public string? cm_house { get; set; }
}
