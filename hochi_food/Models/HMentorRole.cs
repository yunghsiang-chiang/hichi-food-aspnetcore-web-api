using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMentorRole
{
    public int HID { get; set; }

    /// <summary>
    /// 導師角色名稱(ex:教練、總領、傳導師...)
    /// </summary>
    public string? HMentorRoleName { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? HSort { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
