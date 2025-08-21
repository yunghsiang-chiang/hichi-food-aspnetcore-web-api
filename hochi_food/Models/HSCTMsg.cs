using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCTMsg
{
    public int HID { get; set; }

    /// <summary>
    /// 主題HID(HSCTopic.HID)
    /// </summary>
    public int? HSCTopicID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 內容
    /// </summary>
    public string? HContent { get; set; }

    /// <summary>
    /// 上傳檔案1
    /// </summary>
    public string? HFile1 { get; set; }

    /// <summary>
    /// 影片嵌入連結
    /// </summary>
    public string? HVideoLink { get; set; }

    /// <summary>
    /// 是否為提問(0:不是、1:是)
    /// </summary>
    public int? HQuestionYN { get; set; }

    /// <summary>
    /// 狀態(0:刪掉/1:正常/2:隱藏
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
