using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDharmaRecord
{
    public int HID { get; set; }

    /// <summary>
    /// 受傳法HID
    /// </summary>
    public int? HDharmaID { get; set; }

    /// <summary>
    /// 紀錄表名稱
    /// </summary>
    public string? HDRecordName { get; set; }

    /// <summary>
    /// 須完成人數/次數
    /// </summary>
    public int? HCompletedTimes { get; set; }

    /// <summary>
    /// 通知的檢核點(人數/次數)
    /// </summary>
    public string? HNoticeNum { get; set; }

    /// <summary>
    /// 簡述介紹
    /// </summary>
    public string? HIntroduction { get; set; }

    /// <summary>
    /// 檔案(PDF) 多個用json格式存
    /// </summary>
    public string? HFilePDF { get; set; }

    /// <summary>
    /// 檔案(mp3) 多個用json格式存
    /// </summary>
    public string? HFileMusic { get; set; }

    /// <summary>
    /// 法影連結(json格式，名稱+超連結)
    /// </summary>
    public string? HLink { get; set; }

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
