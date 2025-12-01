using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HAreaMonthlySummary
{
    public int Id { get; set; }

    public short SnapshotYear { get; set; }

    public byte SnapshotMonth { get; set; }

    public string LAreaName { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public int ActiveMemberCount_EndOfMonth { get; set; }

    public int NewFriendActiveCount_EndOfMonth { get; set; }

    public int NewFriendCount_ThisMonth { get; set; }

    public int NewMemberCount_ThisMonth { get; set; }

    public int DeadCount_ThisMonth { get; set; }

    public int LeaveCount_ThisMonth { get; set; }

    public int NetGrowth_ThisMonth { get; set; }

    public int NewMemberCum_ThisYear { get; set; }

    public DateTime SnapshotCreatedAt { get; set; }

    public string? Remark { get; set; }
}
