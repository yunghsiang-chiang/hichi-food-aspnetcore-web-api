using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HApplicationItemCC
{
    public int HId { get; set; }

    public int HApplicationItemId { get; set; }

    public string HCCPeriodCode { get; set; } = null!;

    public int? HCreatedByHID { get; set; }

    public DateTime HCreatedAt { get; set; }

    public DateTime? HUpdatedAt { get; set; }

    public int? HApplyCardId { get; set; }

    public virtual HApplicationItem HApplicationItem { get; set; } = null!;
}
