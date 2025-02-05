using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class OrderList_Zoom
{
    public int? HMemberID { get; set; }

    public int? HCourseID { get; set; }

    public int? HAttend { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    public string? HCourseLink { get; set; }

    public string? HSATCourseLink { get; set; }

    public string? HSUNCourseLink { get; set; }

    public string? HCourseLinkRelay { get; set; }

    public string? HCourseLinkTask { get; set; }

    public int? HShowZoom { get; set; }

    public string? HOCPlace { get; set; }

    public string? HPlaceName { get; set; }

    public int? HItemStatus { get; set; }

    public int? HStatus { get; set; }
}
