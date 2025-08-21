using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamScore
{
    public int HID { get; set; }

    /// <summary>
    /// 檢覈名稱HID
    /// </summary>
    public int? HCourseID { get; set; }

    /// <summary>
    /// 1:非教練檢覈/2:教練檢覈
    /// </summary>
    public int? HType { get; set; }

    /// <summary>
    /// 考場名稱(dbo.HPlace.HID)
    /// </summary>
    public int? HPlaceID { get; set; }

    /// <summary>
    /// 教室名稱(dbo.HExamClassRoom.HID)
    /// </summary>
    public int? HExamClassRoomID { get; set; }

    /// <summary>
    /// 科目名稱(dbo.HExamSubject.HID)
    /// </summary>
    public int? HExamSubjectID { get; set; }

    /// <summary>
    /// 考生編號
    /// </summary>
    public string? HExamineeCode { get; set; }

    /// <summary>
    /// 考生HID
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 主考官成績1
    /// </summary>
    public int? HScore1 { get; set; }

    /// <summary>
    /// 檢覈結果1
    /// </summary>
    public int? HExamResult1 { get; set; }

    /// <summary>
    /// 主考官成績2
    /// </summary>
    public int? HScore2 { get; set; }

    /// <summary>
    /// 檢覈結果2
    /// </summary>
    public int? HExamResult2 { get; set; }

    /// <summary>
    /// 主考官成績3
    /// </summary>
    public int? HScore3 { get; set; }

    /// <summary>
    /// 檢覈結果3
    /// </summary>
    public int? HExamResult3 { get; set; }

    /// <summary>
    /// 總成績
    /// </summary>
    public int? HFinalScore { get; set; }

    /// <summary>
    /// 總檢覈結果
    /// </summary>
    public int? HFinalExamResult { get; set; }

    /// <summary>
    /// 評語
    /// </summary>
    public string? HComment { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
