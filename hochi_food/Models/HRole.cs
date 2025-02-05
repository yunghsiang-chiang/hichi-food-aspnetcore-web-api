using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HRole
{
    public int HID { get; set; }

    public string? HRNum { get; set; }

    public string? HUTaskClass { get; set; }

    public string? HUTSystem { get; set; }

    public string? HRName { get; set; }

    public string? HMemberID { get; set; }

    public string? HRAccess { get; set; }

    /// <summary>
    /// 角色類別(1=常態任務、2=天命法位)
    /// </summary>
    public string? HRType { get; set; }

    /// <summary>
    /// 是否跨區(只運用於學員管理的權限判斷)
    /// </summary>
    public bool? HCrossRegion { get; set; }

    public bool? HTMaterialView { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
