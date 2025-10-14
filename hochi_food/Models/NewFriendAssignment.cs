using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class NewFriendAssignment
{
    public int AssignmentId { get; set; }

    public int NewFriendId { get; set; }

    public int ContactHID { get; set; }

    public string Channel { get; set; } = null!;

    public DateTime FirstMetAt { get; set; }

    public string? Note { get; set; }
}
