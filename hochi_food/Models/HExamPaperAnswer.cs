using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamPaperAnswer
{
    public int HID { get; set; }

    public int HCourseID { get; set; }

    public int HExamPaperID { get; set; }

    public int HExamPaperGroup { get; set; }

    public int HMemberID { get; set; }

    public string? HExamPaper { get; set; }

    public string? HExamPaperOption { get; set; }

    public string? HAnswer { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string HCandidateNo { get; set; } = null!;
}
