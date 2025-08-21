using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamBaseAnswer
{
    public int HID { get; set; }

    public int HCourseID { get; set; }

    public int HExamBaseID { get; set; }

    public int HExamBaseGroup { get; set; }

    public int HMemberID { get; set; }

    public string? HExamBase { get; set; }

    public string? HExamBaseOption { get; set; }

    public string? HAnswer { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
