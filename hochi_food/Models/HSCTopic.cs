using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCTopic
{
    public int HID { get; set; }

    /// <summary>
    /// 課程HID
    /// </summary>
    public string? HCourseID { get; set; }

    /// <summary>
    /// 討論區名稱HID(HSCForumClass.HID)
    /// </summary>
    public int? HSCForumClassID { get; set; }

    /// <summary>
    /// 主題名稱
    /// </summary>
    public string? HTopicName { get; set; }

    /// <summary>
    /// 是否置頂
    /// </summary>
    public bool? HPinTop { get; set; }

    /// <summary>
    /// 專欄類別HID (HSCClass.HID)
    /// </summary>
    public int? HSCClassID { get; set; }

    /// <summary>
    /// 紀錄類型HID (HSCRecordType.HID)
    /// </summary>
    public int? HSCRecordTypeID { get; set; }

    /// <summary>
    /// 九宮格類型
    /// </summary>
    public int? HSCJiugonggeTypeID { get; set; }

    /// <summary>
    /// 成長紀錄
    /// </summary>
    public int? HGProgress { get; set; }

    /// <summary>
    /// 其他成長紀錄
    /// </summary>
    public int? HOGProgress { get; set; }

    /// <summary>
    /// 主題內容
    /// </summary>
    public string? HContent { get; set; }

    /// <summary>
    /// 附件一
    /// </summary>
    public string? HFile1 { get; set; }

    /// <summary>
    /// 附件二
    /// </summary>
    public string? HFile2 { get; set; }

    /// <summary>
    /// 附件三
    /// </summary>
    public string? HFile3 { get; set; }

    /// <summary>
    /// 影片連結
    /// </summary>
    public string? HVideoLink { get; set; }

    /// <summary>
    /// HashTag標籤
    /// </summary>
    public string? HHashTag { get; set; }

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
    public string? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public string? HModifyDT { get; set; }
}
