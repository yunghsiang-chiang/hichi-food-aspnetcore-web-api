using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPracticeRecordAnswer
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 關聯哪一張築基紀錄
    /// </summary>
    public int HPracticeRecordID { get; set; }

    /// <summary>
    /// 題號(題目群組)
    /// </summary>
    public int HQuestionGroup { get; set; }

    public int? HSubQuestionGroup { get; set; }

    /// <summary>
    /// 學員ID(填寫者)
    /// </summary>
    public int HMemberID { get; set; }

    /// <summary>
    /// 題目
    /// </summary>
    public string? HQuestion { get; set; }

    /// <summary>
    /// 作答的題目選項(文字)
    /// </summary>
    public string? HQuestionOption { get; set; }

    /// <summary>
    /// 作答的題目答案(數值)
    /// </summary>
    public string? HQuestionAnswer { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? HModifyDT { get; set; }
}
