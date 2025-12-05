using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMemberFunnelHistory
{
    public int HID { get; set; }

    public DateOnly? NewFriendDate { get; set; }

    public DateOnly? FirstCareDate { get; set; }

    public DateOnly? FirstClassDate { get; set; }

    public DateOnly? HappyClassDate { get; set; }

    public DateOnly? NewMemberDate { get; set; }

    public int? FirstClassCourseID { get; set; }

    public int? HappyClassCourseID { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
