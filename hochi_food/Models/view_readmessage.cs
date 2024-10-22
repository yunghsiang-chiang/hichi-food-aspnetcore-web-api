using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class view_readmessage
{
    public string rm_funcname { get; set; } = null!;

    public string rm_funcid { get; set; } = null!;

    public string rm_uid { get; set; } = null!;

    public long tcount { get; set; }
}
