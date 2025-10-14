using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class Interactions
{
    public int InteractionId { get; set; }

    public int NewFriendId { get; set; }

    public int ContactHID { get; set; }

    public string Method { get; set; } = null!;

    public string? IntentLevel { get; set; }

    public string? NextAction { get; set; }

    public DateOnly? NextActionDate { get; set; }

    public string? Memo { get; set; }

    public DateTime CreatedAt { get; set; }
}
