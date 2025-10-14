using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCoApplicant
{
    public int HId { get; set; }

    public int HApplicationId { get; set; }

    public string HCoApplicantName { get; set; } = null!;

    public string? HPeriod { get; set; }

    public string? HDharmaSeat { get; set; }

    public bool? HIsGroup { get; set; }

    public int? HGroupNumber { get; set; }

    public virtual HApplication HApplication { get; set; } = null!;
}
