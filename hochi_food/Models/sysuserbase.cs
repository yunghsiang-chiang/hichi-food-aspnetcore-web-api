using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class sysuserbase
{
    public string UB_ID { get; set; } = null!;

    public string UB_Account { get; set; } = null!;

    public string UB_Name { get; set; } = null!;

    public string UB_pwd { get; set; } = null!;

    public string UB_Cdate { get; set; } = null!;

    public string UB_EffDate { get; set; } = null!;

    public string UB_ExpDate { get; set; } = null!;

    public string UB_CName { get; set; } = null!;

    public string UB_Udate { get; set; } = null!;

    public string UB_UName { get; set; } = null!;

    public string UB_Type { get; set; } = null!;

    public string? UB_GUID { get; set; }
}
