using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class hbquestion
{
    public string hbq_id { get; set; } = null!;

    public sbyte hbq_type { get; set; }

    public string hbq_title { get; set; } = null!;

    public string? hbq_desc { get; set; }

    public string hbq_uid { get; set; } = null!;

    public sbyte hbq_status { get; set; }

    public string hbq_cdate { get; set; } = null!;

    public string hbq_cname { get; set; } = null!;

    public string hbq_udate { get; set; } = null!;

    public string hbq_uname { get; set; } = null!;
}
