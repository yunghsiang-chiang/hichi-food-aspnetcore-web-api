using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HApplyCard
{
    public int HId { get; set; }

    public int HApplicantHID { get; set; }

    public string? Alias { get; set; }

    public string CardHolder { get; set; } = null!;

    public string PersonId { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Bank { get; set; }

    public string No1 { get; set; } = null!;

    public string No2 { get; set; } = null!;

    public string No3 { get; set; } = null!;

    public string No4 { get; set; } = null!;

    public string MM { get; set; } = null!;

    public string YY { get; set; } = null!;

    public string? CVC { get; set; }

    public int Times { get; set; }

    public int Total { get; set; }

    public int Amount { get; set; }

    public string? SDate { get; set; }

    public string? EDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
