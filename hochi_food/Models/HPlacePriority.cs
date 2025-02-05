using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPlacePriority
{
    public int HID { get; set; }

    /// <summary>
    /// 關聯HMember.HID
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 關聯HPlace.HID
    /// </summary>
    public int? HPlaceID { get; set; }

    /// <summary>
    /// 順序(先到後:由小至大)
    /// </summary>
    public int? HPriority { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
