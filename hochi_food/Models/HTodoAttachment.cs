using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTodoAttachment
{
    public int AttachmentId { get; set; }

    public int TodoId { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? ThumbPath { get; set; }

    public string MimeType { get; set; } = null!;

    public int FileSizeBytes { get; set; }

    public int UploadedByHID { get; set; }

    public DateTime UploadedAt { get; set; }

    public int SortOrder { get; set; }

    public bool IsCover { get; set; }
}
