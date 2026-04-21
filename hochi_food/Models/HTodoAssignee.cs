using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTodoAssignee
{
    public int TodoAssigneeId { get; set; }

    public int TodoId { get; set; }

    public int AssigneeHID { get; set; }

    public bool IsOwner { get; set; }

    public DateTime AssignedAt { get; set; }

    public DateTime? CompletedAt { get; set; }
}
