using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HQuestionAnswer
{
    public int HID { get; set; }

    public int? HCourseID { get; set; }

    public int? HQuestionID { get; set; }

    public int? HQuestionGroup { get; set; }

    public int? HMemberID { get; set; }

    public string? HQuestion { get; set; }

    public string? HQuestionOption { get; set; }

    public string? HAnswer { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
