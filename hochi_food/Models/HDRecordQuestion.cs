using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDRecordQuestion
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 法築基紀錄HID
    /// </summary>
    public int HDharmaRecordID { get; set; }

    /// <summary>
    /// 題號(題目群組)
    /// </summary>
    public string? HQuestionGroup { get; set; }

    /// <summary>
    /// 關聯題目模組HID
    /// </summary>
    public int? HSubQuestionID { get; set; }

    /// <summary>
    /// 題目
    /// </summary>
    public string? HQuestionName { get; set; }

    public string? HQuestionInfo { get; set; }

    /// <summary>
    /// 題目類型(1=單選題、2=多選題、3=問答題)
    /// </summary>
    public int? HQuestionType { get; set; }

    /// <summary>
    /// 題目選項
    /// </summary>
    public string? HQuestionItem { get; set; }

    /// <summary>
    /// 題目順序
    /// </summary>
    public int? HSort { get; set; }

    /// <summary>
    /// 關聯下一題號
    /// </summary>
    public int? HRelatedQGroup { get; set; }

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
