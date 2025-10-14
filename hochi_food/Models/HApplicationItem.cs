using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HApplicationItem
{
    public int HId { get; set; }

    public int HApplicationId { get; set; }

    public int HBlessedPersonId { get; set; }

    public string HStatus { get; set; } = null!;

    public int? HAssignedYear { get; set; }

    public DateTime? HLastEditAt { get; set; }

    public DateTime? HLockedAt { get; set; }

    public virtual HApplication HApplication { get; set; } = null!;

    public virtual HBlessedPerson HBlessedPerson { get; set; } = null!;
}
