using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class faqreply
{
    public string faqr_id { get; set; } = null!;

    public string faqr_faqid { get; set; } = null!;

    public string faqr_uid { get; set; } = null!;

    public string faqr_content { get; set; } = null!;

    public sbyte faqr_status { get; set; }

    public string faqr_cdate { get; set; } = null!;

    public string faqr_cname { get; set; } = null!;

    public string faqr_udate { get; set; } = null!;

    public string faqr_uname { get; set; } = null!;

    public string? faqr_file1 { get; set; }

    public string? faqr_file2 { get; set; }

    public string? faqr_file3 { get; set; }

    public string? faqr_parent { get; set; }
}
