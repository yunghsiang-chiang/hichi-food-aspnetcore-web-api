using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamPaperItem
{
    public int HID { get; set; }

    public int? HExamBaseID { get; set; }

    public int? HExamPaperID { get; set; }

    public int? HExamPaperGroup { get; set; }

    public int? HExamPaperNo { get; set; }

    public int? HExamBaseGroup { get; set; }

    public int? HSort { get; set; }

    public int? HScore { get; set; }

    public int? HOriginalSort { get; set; }

    public int? HExamPaperType { get; set; }

    public string? HExamPaper { get; set; }

    public string? HExamPaperOption { get; set; }

    public bool? HRequired { get; set; }

    public bool? HIsAnswer { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
