using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class funcbase
{
    public string F_ID { get; set; } = null!;

    public string F_NAME { get; set; } = null!;

    public string? F_LINK { get; set; }

    public string F_CDATE { get; set; } = null!;

    public string F_PARENT { get; set; } = null!;

    public int F_ORDER { get; set; }

    public int F_STATUS { get; set; }

    public string? F_NOTE { get; set; }

    public string? F_CNAME { get; set; }

    public string? F_UDATE { get; set; }

    public string? F_UNAME { get; set; }

    public string? F_ICON { get; set; }

    public string? F_BGCOLOR { get; set; }

    public string? F_CLASS { get; set; }

    public int? F_TARGET { get; set; }

    public int? F_NEW { get; set; }
}
