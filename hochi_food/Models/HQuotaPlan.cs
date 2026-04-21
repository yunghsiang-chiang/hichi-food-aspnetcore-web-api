using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HQuotaPlan
{
    public int HId { get; set; }

    public int HYear { get; set; }

    public string HPhase { get; set; } = null!;

    public int HLimit { get; set; }

    public int HUsed { get; set; }

    public bool HOverageAllowed { get; set; }

    public int? HOverageMax { get; set; }

    public int HOverageUsed { get; set; }

    public int HDeferredCount { get; set; }

    public bool HIsOpen { get; set; }

    public bool HAutoCloseOnFull { get; set; }

    public DateOnly HOpenFrom { get; set; }

    public DateOnly HOpenTo { get; set; }

    public DateOnly HLastUpdated { get; set; }
}
