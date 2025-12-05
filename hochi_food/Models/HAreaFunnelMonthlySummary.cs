using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HAreaFunnelMonthlySummary
{
    public int Id { get; set; }

    public short SnapshotYear { get; set; }

    public byte SnapshotMonth { get; set; }

    public int? LAreaId { get; set; }

    public string? LAreaName { get; set; }

    public int? AreaId { get; set; }

    public string? AreaName { get; set; }

    public int NewFriendCount_ThisMonth { get; set; }

    public int FirstCareCount_ThisMonth { get; set; }

    public int FirstClassCount_ThisMonth { get; set; }

    public int HappyClassCount_ThisMonth { get; set; }

    public int NewMemberCount_ThisMonth { get; set; }

    public int NewFriendCum_ThisYear { get; set; }

    public int FirstCareCum_ThisYear { get; set; }

    public int FirstClassCum_ThisYear { get; set; }

    public int HappyClassCum_ThisYear { get; set; }

    public int NewMemberCum_ThisYear { get; set; }

    public DateTime LastRebuildAt { get; set; }
}
