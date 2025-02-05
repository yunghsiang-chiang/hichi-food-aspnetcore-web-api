using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HAxisMTeam
{
    public int HID { get; set; }

    public string? HMTeam { get; set; }

    public int? HMLeaderID { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HType { get; set; }

    public int? HALeaderID { get; set; }
}
