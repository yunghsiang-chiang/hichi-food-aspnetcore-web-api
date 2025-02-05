using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HQuestionItem
{
    public int HID { get; set; }

    public int? HQuestionID { get; set; }

    public int? HQuestionNo { get; set; }

    public int? HQuestionGroup { get; set; }

    public int? HSort { get; set; }

    public int? HOriginalSort { get; set; }

    public int? HQuestionType { get; set; }

    public string? HQuestion { get; set; }

    public string? HQuestionOption { get; set; }

    public bool? HRequired { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
