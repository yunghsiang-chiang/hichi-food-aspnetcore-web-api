using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class dharmanews
{
    public string dn_id { get; set; } = null!;

    public string dn_title { get; set; } = null!;

    public string dn_content { get; set; } = null!;

    public sbyte dn_status { get; set; }

    public string dn_cdate { get; set; } = null!;

    public string dn_cname { get; set; } = null!;

    public string dn_udate { get; set; } = null!;

    public string dn_uname { get; set; } = null!;

    public string dn_link { get; set; } = null!;

    public int dn_imp { get; set; }

    public string dn_len { get; set; } = null!;
}
