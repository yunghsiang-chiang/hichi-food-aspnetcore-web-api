using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamSubjectScoreItem
{
    public int HID { get; set; }

    public int HExamSubjectID { get; set; }

    public int HScoreItemID { get; set; }

    public int HSort { get; set; }

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }

    public virtual ICollection<HCommentLibrary> HCommentLibrary { get; set; } = new List<HCommentLibrary>();

    public virtual HExamSubject HExamSubject { get; set; } = null!;

    public virtual HScoreItem HScoreItem { get; set; } = null!;
}
