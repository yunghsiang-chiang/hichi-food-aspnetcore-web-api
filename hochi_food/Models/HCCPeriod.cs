using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCPeriod
{
    public int HId { get; set; }

    public int HApplicationId { get; set; }

    public string HAuthType { get; set; } = null!;

    public string HAuthStatus { get; set; } = null!;

    public string? HAuthDocUrl { get; set; }

    public DateTime HUpdatedAt { get; set; }

    public virtual HApplication HApplication { get; set; } = null!;

    public virtual ICollection<HCCPeriodDetail> HCCPeriodDetail { get; set; } = new List<HCCPeriodDetail>();
}
