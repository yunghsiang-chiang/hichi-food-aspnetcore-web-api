﻿using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMTeam
{
    public int HID { get; set; }

    public int? HLAreaID { get; set; }

    public int? HAreaID { get; set; }

    public string? HMTeam1 { get; set; }

    public int? HMLeaderID { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HType { get; set; }

    public int? HALeaderID { get; set; }
}
