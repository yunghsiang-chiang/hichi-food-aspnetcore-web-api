using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class meeting
{
    public string m_id { get; set; } = null!;

    public string m_category { get; set; } = null!;

    public string m_date { get; set; } = null!;

    public string m_title { get; set; } = null!;

    public string? m_content { get; set; }

    public string m_manager { get; set; } = null!;

    public sbyte m_status { get; set; }

    public string m_cdate { get; set; } = null!;

    public string m_cname { get; set; } = null!;

    public string m_udate { get; set; } = null!;

    public string m_uname { get; set; } = null!;

    public string? m_file1 { get; set; }

    public string? m_file2 { get; set; }

    public string? m_file3 { get; set; }

    public string? m_no { get; set; }

    public string? m_notes { get; set; }
}
