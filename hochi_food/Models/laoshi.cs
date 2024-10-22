using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class laoshi
{
    public string l_id { get; set; } = null!;

    public string l_uid { get; set; } = null!;

    public string l_content { get; set; } = null!;

    public int l_status { get; set; }

    public string l_cdate { get; set; } = null!;

    public string l_cname { get; set; } = null!;

    public string l_udate { get; set; } = null!;

    public string l_uname { get; set; } = null!;

    public string l_recorddate { get; set; } = null!;

    public int l_imp { get; set; }

    public string l_title { get; set; } = null!;

    public string? l_file1 { get; set; }

    public string? l_file2 { get; set; }

    public string? l_file3 { get; set; }

    public int l_impuser { get; set; }

    public sbyte l_iscurrent { get; set; }

    public int? l_no { get; set; }

    public string l_url { get; set; } = null!;

    public sbyte? l_classlevel { get; set; }

    public string? l_attcat { get; set; }

    public string? l_contentcat { get; set; }

    public string? l_titlecat { get; set; }

    public string? l_dharmacat { get; set; }

    public string? l_titleabstract { get; set; }

    public string? l_class { get; set; }

    public string? l_speakdate { get; set; }

    public string? l_subno { get; set; }

    public string? l_place { get; set; }

    public string? l_filelength { get; set; }

    public sbyte l_category { get; set; }

    public int l_rq { get; set; }

    public sbyte? l_isgr { get; set; }

    public int? l_share { get; set; }

    public int? l_reply { get; set; }

    public int? l_question { get; set; }

    public int? l_thank { get; set; }

    public int? l_apply { get; set; }

    public int? l_today { get; set; }
}
