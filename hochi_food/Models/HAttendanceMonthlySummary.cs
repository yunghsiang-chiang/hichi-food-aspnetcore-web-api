using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HAttendanceMonthlySummary
{
    public int Id { get; set; }

    public short SnapshotYear { get; set; }

    public byte SnapshotMonth { get; set; }

    public string LAreaName { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public int MorningUp_DistinctAttendeeCount { get; set; }

    public int MorningDown_DistinctAttendeeCount { get; set; }

    public int Happiness_DistinctAttendeeCount { get; set; }

    public int CoreDistinctAttendeeCount { get; set; }

    public int MorningUp_SessionCount { get; set; }

    public int MorningDown_SessionCount { get; set; }

    public int Happiness_SessionCount { get; set; }

    public DateTime SnapshotCreatedAt { get; set; }

    public string? Remark { get; set; }
}
