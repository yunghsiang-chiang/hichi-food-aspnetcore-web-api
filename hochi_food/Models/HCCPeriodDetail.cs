using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCPeriodDetail
{
    public int HId { get; set; }

    public int HCCPeriodId { get; set; }

    public DateTime HChargeAt { get; set; }

    public decimal HAmount { get; set; }

    public string HChargeStatus { get; set; } = null!;

    public string? HNote { get; set; }

    public virtual HCCPeriod HCCPeriod { get; set; } = null!;
}
