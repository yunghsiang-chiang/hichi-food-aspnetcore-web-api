using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class xx_Invoice
{
    public string? 區屬 { get; set; }

    public string? 捐款人 { get; set; }

    public string? 收據抬頭 { get; set; }

    public string 臨時收據編號 { get; set; } = null!;

    public string? 捐款日期 { get; set; }

    public string 捐款方式 { get; set; } = null!;

    public string 列入捐款 { get; set; } = null!;

    public string 捐款用途 { get; set; } = null!;

    public string 捐款項目 { get; set; } = null!;

    public string? 專案活動 { get; set; }

    public int? 捐款金額 { get; set; }

    public string 收據開立 { get; set; } = null!;

    public string 入帳銀行 { get; set; } = null!;

    public string 入帳日期 { get; set; } = null!;

    public string? 電子信箱 { get; set; }

    public string 是否願意將捐款資料上傳國稅局 { get; set; } = null!;

    public string? 身分證_統編_居留證 { get; set; }

    public string 海外編號 { get; set; } = null!;

    public string 電話 { get; set; } = null!;

    public string? 行動電話 { get; set; }

    public string 郵遞區號 { get; set; } = null!;

    public string 縣市 { get; set; } = null!;

    public string 鄉鎮市區 { get; set; } = null!;

    public string 地址 { get; set; } = null!;

    public string 代收銀行別 { get; set; } = null!;

    public string 徵信抬頭 { get; set; } = null!;

    public string? 備註欄 { get; set; }

    public string? HPaymentDate { get; set; }
}
