﻿using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HWTItem
{
    public int HID { get; set; }

    public int? HWType { get; set; }

    public string? HWTItemName { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
