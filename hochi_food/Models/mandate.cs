using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class mandate
{
    public string m_id { get; set; } = null!;

    public string? m_psnid { get; set; }

    public string? m_uid { get; set; }

    public string? m_begdate { get; set; }

    public string m_enddate { get; set; } = null!;

    public int m_order { get; set; }

    public int? m_category { get; set; }

    public string m_filename { get; set; } = null!;

    public string m_content { get; set; } = null!;

    public string m_cdate { get; set; } = null!;

    public string m_cname { get; set; } = null!;

    public string m_udate { get; set; } = null!;

    public string m_uname { get; set; } = null!;

    public string m_name { get; set; } = null!;

    public string m_aid { get; set; } = null!;
}
