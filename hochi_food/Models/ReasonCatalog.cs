using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class ReasonCatalog
{
    public string ReasonCode { get; set; } = null!;

    public string ReasonName { get; set; } = null!;

    public string? Category { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
