using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class v_event_contact_log
{
    public int NewFriendId { get; set; }

    public int ContactHID { get; set; }

    public string Method { get; set; } = null!;

    public string? IntentLevel { get; set; }

    public string? NextAction { get; set; }

    public DateOnly? NextActionDate { get; set; }

    public string? Memo { get; set; }

    public DateTime? EventAt { get; set; }

    public string EventType { get; set; } = null!;
}
