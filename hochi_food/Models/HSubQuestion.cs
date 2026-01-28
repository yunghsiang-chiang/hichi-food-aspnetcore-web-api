using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSubQuestion
{
    public int HID { get; set; }

    public int? HSubQuestionGroup { get; set; }

    /// <summary>
    /// 題目模組名稱
    /// </summary>
    public string? HSubQuestionName { get; set; }

    public string? HSubQuestionInfo { get; set; }

    /// <summary>
    /// 題目類型(1=單選題、2=多選題、3=問答題、4=分數量表、5=滑桿式)
    /// </summary>
    public int? HSubQuestionType { get; set; }

    /// <summary>
    /// 題目選項
    /// </summary>
    public string? HSubQuestionItem { get; set; }

    public string? HSubQuestionItemInfo { get; set; }

    public int? HMinScore { get; set; }

    public int? HMaxScore { get; set; }

    public string? HLeftLabel { get; set; }

    public string? HRightLabel { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? HSort { get; set; }

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
