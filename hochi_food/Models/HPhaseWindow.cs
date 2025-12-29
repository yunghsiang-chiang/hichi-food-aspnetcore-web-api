using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPhaseWindow
{
    public int HId { get; set; }

    public int HYear { get; set; }

    public string HPhase { get; set; } = null!;

    public string HTitle { get; set; } = null!;

    public DateTime? HOpenFrom { get; set; }

    public DateTime? HOpenTo { get; set; }

    public bool HIsOpen { get; set; }

    public bool HAutoCloseOnFull { get; set; }

    public int? HWindowLimit { get; set; }

    public int HWindowUsed { get; set; }

    public DateOnly? HCreatedAt { get; set; }

    public DateOnly HUpdatedAt { get; set; }
}
