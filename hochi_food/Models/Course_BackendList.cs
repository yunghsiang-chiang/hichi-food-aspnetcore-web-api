using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class Course_BackendList
{
    public long? Row_ { get; set; }

    public int HID { get; set; }

    public string? HCourseName { get; set; }

    public string? HTeacherName { get; set; }

    public string? HTeam { get; set; }

    public string? HCourseNum { get; set; }

    public string? HDateRange { get; set; }

    public string? HDharmaID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? TeacherName { get; set; }

    public string? HTMemberID { get; set; }

    public string? HOCPlace { get; set; }

    public string? HPlaceName { get; set; }

    public int HStatus { get; set; }

    public int? HVerifyStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HSave { get; set; }

    public int? HSerial { get; set; }
}
