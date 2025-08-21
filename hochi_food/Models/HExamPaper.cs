using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamPaper
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HExamPaperNum { get; set; }

    public string? HTitle { get; set; }

    public string? HExamBaseID { get; set; }

    public string? HIntroduce { get; set; }

    public string? HFeedBack { get; set; }

    public string? HExamPaperClass { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
