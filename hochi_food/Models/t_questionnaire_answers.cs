using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class t_questionnaire_answers
{
    public string 問卷名稱 { get; set; } = null!;

    public string? 時間戳記 { get; set; }

    public string 電子郵件地址 { get; set; } = null!;

    public string? 上課日期 { get; set; }

    public string 姓名 { get; set; } = null!;

    public string? 區屬 { get; set; }

    /// <summary>
    /// 問題
    /// </summary>
    public string question { get; set; } = null!;

    public string? 回答 { get; set; }
}
