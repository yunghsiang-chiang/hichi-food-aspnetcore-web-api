using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class DocumentLinks
{
    public int DocId { get; set; }

    public int NewFriendId { get; set; }

    public string Title { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public string? Tag { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedByHID { get; set; }
}
