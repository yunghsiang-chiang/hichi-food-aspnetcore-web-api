using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCGRMsg
{
    public int HID { get; set; }

    /// <summary>
    /// 學員HID(HMember.HID)
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 主題名稱
    /// </summary>
    public string? HTopicName { get; set; }

    /// <summary>
    /// 課程名稱HID(HCourse.HID)
    /// </summary>
    public string? HCourseID { get; set; }

    /// <summary>
    /// 專欄分類HID(HSCClass.HID)
    /// </summary>
    public int? HSCClassID { get; set; }

    /// <summary>
    /// 紀錄類型HID(HSCRecordType.HID)
    /// </summary>
    public int? HSCRecordTypeID { get; set; }

    /// <summary>
    /// 九宮格類型
    /// </summary>
    public int? HSCJiugonggeTypeID { get; set; }

    /// <summary>
    /// 成長進度
    /// </summary>
    public int? HGProgress { get; set; }

    /// <summary>
    /// 其他成長進度
    /// </summary>
    public string? HOGProgress { get; set; }

    /// <summary>
    /// 內容
    /// </summary>
    public string? HContent { get; set; }

    /// <summary>
    /// 上傳檔案1
    /// </summary>
    public string? HFile1 { get; set; }

    /// <summary>
    /// 上傳檔案2
    /// </summary>
    public string? HFile2 { get; set; }

    /// <summary>
    /// 上傳檔案3
    /// </summary>
    public string? HFile3 { get; set; }

    /// <summary>
    /// 影片嵌入連結
    /// </summary>
    public string? HVideoLink { get; set; }

    /// <summary>
    /// HashTag標籤
    /// </summary>
    public string? HHashTag { get; set; }

    /// <summary>
    /// 開放對象
    /// </summary>
    public int? HOpenObject { get; set; }

    /// <summary>
    /// 是否通知導師及帶領導師
    /// </summary>
    public bool? HNotifyMentor { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
