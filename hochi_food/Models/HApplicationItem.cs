using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HApplicationItem
{
    public int HId { get; set; }

    public int HApplicationId { get; set; }

    public int? HBlessedPersonId { get; set; }

    public string HStatus { get; set; } = null!;

    public int? HAssignedYear { get; set; }

    public DateTime? HLastEditAt { get; set; }

    public DateTime? HLockedAt { get; set; }

    public string? HBlessedPersonName { get; set; }

    public int? HApplicantHID { get; set; }

    public string? HBlessedAppealLang { get; set; }

    public string? HBlessedLegalLang { get; set; }

    public virtual ICollection<HApplicationItemCC> HApplicationItemCC { get; set; } = new List<HApplicationItemCC>();

    public virtual HBlessedPerson? HBlessedPerson { get; set; }
}
