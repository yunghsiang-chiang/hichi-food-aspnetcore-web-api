using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class ContactEvent
{
    public long EventId { get; set; }

    public long PersonId { get; set; }

    public string EventType { get; set; } = null!;

    public string? Channel { get; set; }

    public DateTime EventTime { get; set; }

    public int? StaffId { get; set; }

    public string? ResultCode { get; set; }

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? CreatedBy { get; set; }
}
