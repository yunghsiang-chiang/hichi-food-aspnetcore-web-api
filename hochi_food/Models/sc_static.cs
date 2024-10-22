using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sc_static
{
    public string u_period { get; set; } = null!;

    public string u_name { get; set; } = null!;

    public int? QTY { get; set; }

    public double Total_Times { get; set; }

    public short status { get; set; }
}
