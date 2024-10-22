using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class x_training
{
    public string t_id { get; set; } = null!;

    public string t_name { get; set; } = null!;

    public string? t_content { get; set; }

    public string t_begdate { get; set; } = null!;

    public string t_enddate { get; set; } = null!;

    public int t_type { get; set; }

    public string t_unit { get; set; } = null!;

    public string t_place { get; set; } = null!;

    public string t_adate { get; set; } = null!;

    public string? t_contact { get; set; }

    public string? t_license { get; set; }

    public string? t_formsurl { get; set; }

    public string? t_formsresulturl { get; set; }

    public int t_ischeck { get; set; }

    public string? t_file { get; set; }

    public string t_filedesc { get; set; } = null!;

    public string t_cdate { get; set; } = null!;

    public string t_udate { get; set; } = null!;

    public string t_uname { get; set; } = null!;
}
