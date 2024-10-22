using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class formquestionsdetail
{
    public string fqd_id { get; set; } = null!;

    public string fqd_fqid { get; set; } = null!;

    public string fqd_uid { get; set; } = null!;

    public sbyte? fqd_status { get; set; }

    public string fqd_cdate { get; set; } = null!;

    public string fqd_cname { get; set; } = null!;

    public string fqd_udate { get; set; } = null!;

    public string fqd_uname { get; set; } = null!;
}
