using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTeacherName
{
    public int HID { get; set; }

    public string? HTeacherName1 { get; set; }

    public string? HExamSubjectID { get; set; }

    public int? HTeacherClass { get; set; }

    public int? HProgramLV { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
