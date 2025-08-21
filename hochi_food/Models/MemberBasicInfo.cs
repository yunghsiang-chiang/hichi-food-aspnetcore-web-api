using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class MemberBasicInfo
{
    public int HID { get; set; }

    public string? HArea { get; set; }

    public string? HPeriod { get; set; }

    public string? HUsername { get; set; }

    public string? HSystemName { get; set; }

    public string? HRName { get; set; }

    public string? HAxisType { get; set; }

    public int HCarrier { get; set; }

    public int HRainbow { get; set; }

    public int? HEIPUid { get; set; }

    public string CarrierName { get; set; } = null!;

    public string RainbowName { get; set; } = null!;

    public string HLightEnvoy { get; set; } = null!;

    public string? HTeamID { get; set; }

    public string? TeamName { get; set; }

    public int? MTeamID { get; set; }

    public string? MotherTeam { get; set; }

    public string? AreaName { get; set; }

    public string? LAreaName { get; set; }

    public int? AreaSort { get; set; }

    public int? LAreaSort { get; set; }

    public string? MentorName { get; set; }

    public string? MMentorName { get; set; }

    public string? AreaHeadName { get; set; }

    public string? HeaderName { get; set; }
}
