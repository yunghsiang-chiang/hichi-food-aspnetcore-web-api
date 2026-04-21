using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTodoComment
{
    public int CommentId { get; set; }

    public int TodoId { get; set; }

    public byte CommentType { get; set; }

    public string? Body { get; set; }

    public byte? FromStatus { get; set; }

    public byte? ToStatus { get; set; }

    public int CreatedByHID { get; set; }

    public DateTime CreatedAt { get; set; }
}
