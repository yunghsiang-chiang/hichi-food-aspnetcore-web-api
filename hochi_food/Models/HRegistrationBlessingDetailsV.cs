using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HRegistrationBlessingDetailsV
{
    public int HApplicationId { get; set; }

    public int HApplicationItemId { get; set; }

    public string HApplicantHID { get; set; } = null!;

    public string HPhase { get; set; } = null!;

    public DateTime HSubmitAt { get; set; }

    public string? HAudioUrl { get; set; }

    public string? HMandateType { get; set; }

    public string? HMandateStatus { get; set; }

    public int HBlessedPersonId { get; set; }

    public string HAppealName { get; set; } = null!;

    public string HLegalName { get; set; } = null!;

    public int? HBirthYear { get; set; }

    public string? HCounty { get; set; }

    public string? HRelation { get; set; }

    public string HStatus { get; set; } = null!;

    public int? HAssignedYear { get; set; }

    public string? HCoApplicants { get; set; }
}
