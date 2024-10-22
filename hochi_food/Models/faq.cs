using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class faq
{
    public string faq_id { get; set; } = null!;

    public string faq_uid { get; set; } = null!;

    public string faq_content { get; set; } = null!;

    public int faq_status { get; set; }

    public string faq_cdate { get; set; } = null!;

    public string faq_cname { get; set; } = null!;

    public string faq_udate { get; set; } = null!;

    public string faq_uname { get; set; } = null!;

    public int faq_imp { get; set; }

    public string faq_title { get; set; } = null!;

    public string? faq_file1 { get; set; }

    public string? faq_file2 { get; set; }

    public string? faq_file3 { get; set; }

    public int faq_impuser { get; set; }

    public string faq_url { get; set; } = null!;

    public string faq_sid { get; set; } = null!;

    public sbyte faq_isclosed { get; set; }

    public int faq_no { get; set; }

    public sbyte? faq_level { get; set; }

    public string? faq_referral { get; set; }
}
