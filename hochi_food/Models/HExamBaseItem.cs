using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamBaseItem
{
    public int HID { get; set; }

    public int? HExamBaseID { get; set; }

    public int? HExamBaseNo { get; set; }

    public int? HExamBaseGroup { get; set; }

    public int? HSort { get; set; }

    public int? HScore { get; set; }

    public int? HOriginalSort { get; set; }

    public int? HExamBaseType { get; set; }

    public string? HExamBase { get; set; }

    public string? HExamBaseOption { get; set; }

    public bool? HRequired { get; set; }

    public bool? HIsAnswer { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
