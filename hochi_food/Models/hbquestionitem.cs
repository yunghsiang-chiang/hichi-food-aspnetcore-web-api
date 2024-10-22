using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class hbquestionitem
{
    public string hbqi_id { get; set; } = null!;

    public string hbqi_hbqid { get; set; } = null!;

    public sbyte hbqi_no { get; set; }

    public sbyte hbqi_subno { get; set; }

    public sbyte hbqi_status { get; set; }

    public sbyte hbqi_type { get; set; }

    public string hbqi_title { get; set; } = null!;

    public string? hbqi_value { get; set; }

    public string? hbqi_desc { get; set; }

    public sbyte hbqi_ismust { get; set; }
}
