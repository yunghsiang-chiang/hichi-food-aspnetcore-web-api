using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class CourseList
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HCBatchNum { get; set; }

    public string? HCourseNum { get; set; }

    public string? HCourseName { get; set; }

    public string? HRSystem { get; set; }

    public string? HTeacherName { get; set; }

    public string? HImg { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModifyDT { get; set; }

    public int? HNGuide { get; set; }

    public string? HOCPlace { get; set; }

    public string? HDateRange { get; set; }

    public string? HSTime { get; set; }

    public string? HETime { get; set; }

    public string? HTime { get; set; }

    public int ClassType { get; set; }

    public int? HType { get; set; }

    public string? TypeName { get; set; }

    public string? HPMethod { get; set; }

    public string? HBCPoint { get; set; }

    public string? HContentTitle { get; set; }

    public string? HContent { get; set; }

    public string? HRNContent { get; set; }

    public string? Location { get; set; }

    public int? HNLCourse { get; set; }

    public bool? HDContinous { get; set; }

    public int? HVerifyStatus { get; set; }

    public int HStatus { get; set; }

    public string? HCDeadline { get; set; }

    public int? HCDeadlineDay { get; set; }

    public int? HSerial { get; set; }

    public string? HIRestriction { get; set; }
}
