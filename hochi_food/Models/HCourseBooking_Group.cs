using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseBooking_Group
{
    public int HID { get; set; }

    public int? HBookingID { get; set; }

    public string? HGroupID { get; set; }

    public bool? HSameAsCourse { get; set; }

    public string? HGDay { get; set; }

    public string? HGSTime { get; set; }

    public string? HGETime { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HTaskID { get; set; }

    public string? HTask { get; set; }

    public int? HStatus { get; set; }
}
