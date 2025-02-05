using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMailRecord
{
    public int HID { get; set; }

    /// <summary>
    /// 信件主旨
    /// </summary>
    public string? HSubject { get; set; }

    /// <summary>
    /// 信件內容
    /// </summary>
    public string? HBody { get; set; }

    /// <summary>
    /// 圖片
    /// </summary>
    public string? HImg { get; set; }

    public string? HRMail { get; set; }

    /// <summary>
    /// 收件者
    /// </summary>
    public string? HReceiver { get; set; }

    public string? HUsualTask { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
