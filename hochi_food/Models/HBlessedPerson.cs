using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HBlessedPerson
{
    public int HId { get; set; }

    public string HAppealName { get; set; } = null!;

    public string HLegalName { get; set; } = null!;

    public int? HBirthYear { get; set; }

    public string? HCounty { get; set; }

    public string? HAudioUrl { get; set; }

    public int? HAudioSec { get; set; }

    public string HCreatedByHID { get; set; } = null!;

    public DateTime HCreatedAt { get; set; }

    public DateTime HUpdatedAt { get; set; }

    public virtual ICollection<HApplicationItem> HApplicationItem { get; set; } = new List<HApplicationItem>();
}
