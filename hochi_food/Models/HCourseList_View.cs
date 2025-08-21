using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseList_View
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HCBatchNum { get; set; }

    public string? HCourseName { get; set; }

    public string? HTeacherName { get; set; }

    public string? HOCPlace { get; set; }

    public string? HDateRange { get; set; }

    public int ClassType { get; set; }

    public int? HType { get; set; }

    public string? TypeName { get; set; }

    public string? HPMethod { get; set; }

    public string? HBCPoint { get; set; }

    public int? HVerifyStatus { get; set; }

    public int HStatus { get; set; }

    public int? HCDeadlineDay { get; set; }

    public int? HSerial { get; set; }

    public string? HIRestriction { get; set; }

    public string? HCreateDT { get; set; }

    public int? HIndexShow { get; set; }

    public int? HIndexSort { get; set; }

    public int? HBookByDateYN { get; set; }

    public int? HCCPeriodYN { get; set; }

    public int? HCCPeriodDItem { get; set; }
}
