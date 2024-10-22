using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class totalfee
{
    public string this_year { get; set; } = null!;

    public string item_no { get; set; } = null!;

    public string FEE_CODE { get; set; } = null!;

    public int? out_year { get; set; }

    public string? memo { get; set; }

    public int? status { get; set; }

    public short? seq_no { get; set; }
}
