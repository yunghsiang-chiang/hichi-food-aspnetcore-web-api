using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class Person
{
    public long PersonId { get; set; }

    public string Name { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Phone { get; set; }

    public string? PhoneNorm { get; set; }

    public string? LineId { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? Address { get; set; }

    public string? Source { get; set; }

    public int? ReferrerMemberId { get; set; }

    public string? GroupRegion { get; set; }

    public string? GroupArea { get; set; }

    public string? GroupName { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
