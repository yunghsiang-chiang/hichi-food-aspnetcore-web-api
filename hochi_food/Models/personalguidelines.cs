using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class personalguidelines
{
    public string pl_id { get; set; } = null!;

    public string pl_uid { get; set; } = null!;

    public string pl_applydate { get; set; } = null!;

    public string pl_file { get; set; } = null!;

    public string pl_filedate { get; set; } = null!;

    public string pl_fileuname { get; set; } = null!;

    public string pl_begdate { get; set; } = null!;

    public string pl_enddate { get; set; } = null!;

    public int pl_fee { get; set; }

    public sbyte pl_status { get; set; }

    public string pl_cdate { get; set; } = null!;

    public string pl_cname { get; set; } = null!;

    public string pl_udate { get; set; } = null!;

    public string pl_uname { get; set; } = null!;

    public string? pl_desc { get; set; }
}
