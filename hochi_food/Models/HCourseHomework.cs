using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseHomework
{
    public int HID { get; set; }

    public int HBookingID { get; set; }

    public int? HMemberID { get; set; }

    public string? HContent { get; set; }

    public string? HFile { get; set; }

    public string? HSDate { get; set; }

    public string? HTResponse { get; set; }

    public string? HTRDate { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HLResponse { get; set; }

    public string? HWSettingID { get; set; }
}
