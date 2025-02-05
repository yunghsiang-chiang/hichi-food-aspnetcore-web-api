using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPlaceList
{
    public int HID { get; set; }

    public string? HAreaID { get; set; }

    public string? HPlaceName { get; set; }

    public string? HAreaName { get; set; }

    public int? HStatus { get; set; }

    public int? strHAreaID { get; set; }
}
