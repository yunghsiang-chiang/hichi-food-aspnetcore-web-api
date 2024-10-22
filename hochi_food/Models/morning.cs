using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class morning
{
    public long mm_id { get; set; }

    public int mm_type { get; set; }

    public string mm_ip { get; set; } = null!;

    public string mm_uid { get; set; } = null!;

    public string mm_impdate { get; set; } = null!;

    public string mm_uname { get; set; } = null!;

    public string? mm_note { get; set; }
}
