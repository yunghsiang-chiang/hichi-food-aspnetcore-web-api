using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class v_funnel_30d
{
    public int? stage_new_in { get; set; }

    public int? stage_contacted { get; set; }

    public int? stage_attended { get; set; }

    public int? stage_done { get; set; }
}
