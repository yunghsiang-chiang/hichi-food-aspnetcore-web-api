using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseBooking_DateAttend
{
    public int HID { get; set; }

    public int? HCourseBookingID { get; set; }

    public DateOnly? HDate { get; set; }

    public int? HAttend { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
