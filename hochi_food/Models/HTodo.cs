using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTodo
{
    public int TodoId { get; set; }

    public string Title { get; set; } = null!;

    public string? Body { get; set; }

    public byte Priority { get; set; }

    public byte Status { get; set; }

    public DateOnly? DueDate { get; set; }

    public string? RelatedUrl { get; set; }

    public int CreatedByHID { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? ClosedAt { get; set; }
}
