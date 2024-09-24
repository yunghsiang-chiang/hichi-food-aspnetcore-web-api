using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 這個表用來管理用戶的角色及其對應的訪問權限
/// </summary>
public partial class c_user_roles
{
    /// <summary>
    /// 唯一的識別碼，自動增量
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// 角色的名稱，例如「HR」、「管理者」、「員工」
    /// </summary>
    public string role_name { get; set; } = null!;

    /// <summary>
    /// 記錄角色擁有的訪問權限，以 JSON 格式儲存方便解析
    /// </summary>
    public string permissions { get; set; } = null!;

    /// <summary>
    /// 紀錄該紀錄的創建時間
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 紀錄該紀錄的最後更新時間
    /// </summary>
    public DateTime? updated_at { get; set; }
}
