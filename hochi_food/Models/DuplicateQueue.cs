using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class DuplicateQueue
{
    public int QueueId { get; set; }

    public int CandidateA { get; set; }

    public int CandidateB { get; set; }

    public decimal Score { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string Status { get; set; } = null!;
}
