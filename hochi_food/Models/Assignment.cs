using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class Assignment
{
    public long AssignId { get; set; }

    public long PersonId { get; set; }

    public int AssigneeId { get; set; }

    public string Role { get; set; } = null!;

    public bool ActiveFlag { get; set; }

    public DateTime AssignedAt { get; set; }

    public DateTime? UnassignedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }
}
