using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class formquestions
{
    public string fq_id { get; set; } = null!;

    public string? fq_cid { get; set; }

    public string fq_title { get; set; } = null!;

    public string? fq_desc { get; set; }

    public string fq_uid { get; set; } = null!;

    public sbyte? fq_status { get; set; }

    public string fq_begdate { get; set; } = null!;

    public string fq_enddate { get; set; } = null!;

    public string fq_cdate { get; set; } = null!;

    public string fq_cname { get; set; } = null!;

    public string fq_udate { get; set; } = null!;

    public string fq_uname { get; set; } = null!;

    public string? fq_foreword { get; set; }
}
