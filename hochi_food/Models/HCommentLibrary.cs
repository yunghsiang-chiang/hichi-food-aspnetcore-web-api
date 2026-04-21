using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCommentLibrary
{
    public int HID { get; set; }

    public int HExamSubjectScoreItemID { get; set; }

    /// <summary>
    /// 1:優點、2:須改善
    /// </summary>
    public int HCommentType { get; set; }

    public string HCommentText { get; set; } = null!;

    public int HSort { get; set; }

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }

    public virtual HExamSubjectScoreItem HExamSubjectScoreItem { get; set; } = null!;
}
