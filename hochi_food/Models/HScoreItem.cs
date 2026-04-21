using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HScoreItem
{
    public int HID { get; set; }

    public string HItemName { get; set; } = null!;

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }

    public virtual ICollection<HExamSubjectScoreItem> HExamSubjectScoreItem { get; set; } = new List<HExamSubjectScoreItem>();
}
