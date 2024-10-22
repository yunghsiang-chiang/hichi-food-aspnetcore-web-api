using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class localfee
{
    public string area { get; set; } = null!;

    public string this_year { get; set; } = null!;

    public string FEE_CODE { get; set; } = null!;

    public int? out_01 { get; set; }

    public int? out_02 { get; set; }

    public int? out_03 { get; set; }

    public int? out_04 { get; set; }

    public int? out_05 { get; set; }

    public int? out_06 { get; set; }

    public int? out_07 { get; set; }

    public int? out_08 { get; set; }

    public int? out_09 { get; set; }

    public int? out_10 { get; set; }

    public int? out_11 { get; set; }

    public int? out_12 { get; set; }

    public int? status { get; set; }

    public short? seq_no { get; set; }
}
