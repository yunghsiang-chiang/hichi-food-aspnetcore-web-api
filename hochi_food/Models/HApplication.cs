using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HApplication
{
    public int HId { get; set; }

    public string HApplicantHID { get; set; } = null!;

    public string HPhase { get; set; } = null!;

    public DateTime HSubmitAt { get; set; }

    public string? HAudioUrl { get; set; }

    public int? HAudioSec { get; set; }

    public string? HMandateType { get; set; }

    public string? HMandateStatus { get; set; }

    public string? HCoApplicantsNote { get; set; }

    public byte[]? HBatchKey { get; set; }

    public virtual ICollection<HApplicationItem> HApplicationItem { get; set; } = new List<HApplicationItem>();

    public virtual ICollection<HCoApplicant> HCoApplicant { get; set; } = new List<HCoApplicant>();
}
