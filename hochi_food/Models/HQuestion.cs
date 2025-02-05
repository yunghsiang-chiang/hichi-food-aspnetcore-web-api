using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HQuestion
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HQuestionNum { get; set; }

    public string? HTitle { get; set; }

    public string? HIntroduce { get; set; }

    public string? HFeedBack { get; set; }

    public string? HMemberType { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
