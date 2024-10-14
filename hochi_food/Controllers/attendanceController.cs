using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Bcpg;

namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class attendanceController : ControllerBase
    {
        // 在全域變數宣告資料庫物件 attendanceContext
        private readonly attendanceContext _attendanceContext;

        // 建構函式，將 attendanceContext 的實例注入到控制器中
        public attendanceController(attendanceContext attendanceContext)
        {
            // 將注入的 attendanceContext 賦值給私有變數 _attendanceContext
            _attendanceContext = attendanceContext;
        }

        // HTTP POST 方法，新增出勤資訊記錄
        [HttpPost("appendattendance_infor")]
        public void appendattendance_infor([FromBody] h_attendance_infor h_Attendance_Infor)
        {
            // 將出勤資訊新增到資料庫
            _attendanceContext.Add(h_Attendance_Infor);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP POST 方法，新增每日出勤記錄
        [HttpPost("appendattendance_day")]
        public void appendattendance_day([FromBody] h_attendance_day h_Attendance_Day)
        {
            // 將每日出勤新增到資料庫
            _attendanceContext.Add(h_Attendance_Day);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP POST 方法，新增出勤記錄
        [HttpPost("appendattendance_record")]
        public void appendattendance_record([FromBody] h_attendance_record h_Attendance_Record)
        {
            // 將出勤記錄新增到資料庫
            _attendanceContext.Add(h_Attendance_Record);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP POST 方法，新增請假記錄
        [HttpPost("appendleave_record")]
        public void appendleave_record([FromBody] h_leave_record h_Leave_Record)
        {
            // 將請假記錄新增到資料庫
            _attendanceContext.Add(h_Leave_Record);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP POST 方法，新增加班記錄
        [HttpPost("appendovetime_record")]
        public void appendovetime_record([FromBody] h_overtime_record h_Overtime_Record)
        {
            // 將加班記錄新增到資料庫
            _attendanceContext.Add(h_Overtime_Record);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP POST 方法，新增出勤日曆記錄
        [HttpPost("appendattendance_calendar")]
        public void appendattendance_calendar([FromBody] c_attendance_calendar c_Attendance_Calendar)
        {
            // 將出勤日曆記錄新增到資料庫
            _attendanceContext.Add(c_Attendance_Calendar);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP GET 方法，查詢出勤資訊
        [HttpGet("getAllAttendanceTimes")]
        public IEnumerable<c_attendance_times> getAllAttendanceTimes()
        {
            // 從資料庫中獲取所有的考勤時間記錄
            var attendanceTimes = _attendanceContext.c_attendance_times;

            // 返回考勤時間記錄列表
            return attendanceTimes;
        }


        // HTTP GET 方法，取得今天的出勤記錄
        [HttpGet("get_today_attendance_record")]
        public IEnumerable<h_attendance_record> get_today_attendance_record()
        {
            // 查詢今天的出勤記錄
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.create_time.Date == DateTime.Now.Date
                       select row;
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，根據使用者 ID 取得指定月份的出勤日期
        [HttpGet("get_attendanceDates")]
        public IEnumerable<attendanceDatesDTO> get_attendanceDates(string userid, int attendanceyear, int attendancemonth)
        {
            // 查詢指定使用者在指定年月的出勤日期，篩選出 "到班" 或 "外出公務" 的狀態，並確保日期唯一
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.user_id == userid
                             && row.create_time.Year == attendanceyear
                             && row.create_time.Month == attendancemonth
                             && (row.attendance_status == "到班" || row.attendance_status == "外出公務")
                       group row by row.create_time.Date into g
                       select new attendanceDatesDTO
                       {
                           attendanceDates = g.Key.ToString("yyyy-MM-dd")
                       };

            // 返回去重後的出勤日期
            return temp.Distinct();
        }

        // HTTP GET 方法，根據年份和月份取得出勤天數
        [HttpGet("get_attendanceDays")]
        public IEnumerable<get_attendanceDaysDTO> get_attendanceDays(int calendaryear, int calendarmonth)
        {
            // 查詢指定年月的出勤天數
            var temp = from row in _attendanceContext.c_attendance_calendar
                       where row.calendar_year == calendaryear && row.calendar_month == calendarmonth
                       select new get_attendanceDaysDTO { attendance_days = row.attendance_days };
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，取得今天的打卡時間
        [HttpGet("get_today_check_in_time")]
        public IEnumerable<get_today_check_in_timeDTO> get_today_check_in_time()
        {
            // 將今天的日期轉為字串格式
            string today_date = DateTime.Now.ToString("yyyy-MM-dd");
            // 查詢今天"到班"的打卡時間，按時間排序
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.create_time >= Convert.ToDateTime(today_date + " 00:00:00") && row.attendance_status == "到班"
                       orderby row.create_time descending
                       select new get_today_check_in_timeDTO { create_time = row.create_time };
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，根據使用者 ID 和指定日期取得出勤記錄
        [HttpGet("get_attendance_record_by_date")]
        public IEnumerable<attendance_recordDTO> get_attendance_record(string userid, string attendanceDate)
        {
            // 查詢指定使用者在指定日期的出勤記錄，按時間排序
            var temp = from row in _attendanceContext.h_attendance_record
                       where userid == row.user_id && row.create_time.Date == DateTime.Parse(attendanceDate).Date
                       orderby row.create_time
                       select new attendance_recordDTO { user_id = row.user_id, user_name = row.user_name, attendance_status = row.attendance_status, create_time = row.create_time };
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，根據使用者 ID 和指定時間範圍取得出勤記錄
        [HttpGet("get_attendance_record")]
        public IEnumerable<attendance_recordDTO> get_attendance_record(string userid, DateTime startdate, DateTime enddate)
        {
            // 查詢指定使用者在指定時間範圍內的出勤記錄，按時間排序
            var temp = from row in _attendanceContext.h_attendance_record
                       where userid == row.user_id && row.create_time >= startdate && row.create_time <= enddate.AddDays(1)
                       orderby row.create_time
                       select new attendance_recordDTO { user_id = row.user_id, user_name = row.user_name, attendance_status = row.attendance_status, create_time = row.create_time };
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，取得今天的請假記錄
        [HttpGet("get_today_leave_record")]
        public IEnumerable<h_leave_record> get_today_leave_record()
        {
            // 查詢今天的請假記錄
            var todayLeaveRecords = from record in _attendanceContext.h_leave_record
                                    where record.startTime.Date <= DateTime.Now.Date && record.endTime.Date >= DateTime.Now.Date
                                    select record;

            // 返回查詢結果
            return todayLeaveRecords;
        }

        // HTTP GET 方法，根據使用者 ID 和指定時間範圍取得加班記錄
        [HttpGet("get_overtime_record")]
        public IEnumerable<h_overtime_record> get_overtime_record(string userid, DateTime startdate, DateTime enddate)
        {
            // 查詢指定使用者在指定時間範圍內的加班記錄
            var temp = from row in _attendanceContext.h_overtime_record
                       where userid == row.userID && row.startTime.Date >= startdate.Date && row.endTime <= enddate.Date
                       select row;
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，根據使用者 ID 和指定時間範圍取得請假記錄
        [HttpGet("get_leave_record")]
        public IEnumerable<h_leave_record> get_leave_record(string userid, DateTime startdate, DateTime enddate)
        {
            // 查詢指定使用者在指定時間範圍內的請假記錄
            var temp = from row in _attendanceContext.h_leave_record
                       where userid == row.userId && row.startTime.Date >= startdate.Date && row.endTime.Date <= enddate.Date
                       select row;
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，根據指定年份和月份取得請假記錄
        [HttpGet("get_leave_record_by_year_month")]
        public IEnumerable<h_leave_record> get_leave_record_by_year_month(int year, int month)
        {
            // 查詢指定年月的請假記錄
            var temp = from row in _attendanceContext.h_leave_record
                       where row.startTime.Year == year && row.startTime.Month == month
                       select row;
            // 返回查詢結果
            return temp;
        }

        //HTTP GET 方法，取得1年內請假記錄
        [HttpGet("get_leave_record_last_year")]
        public IEnumerable<h_leave_record> get_leave_record_last_year()
        {
            DateTime last_year_day = DateTime.Now.AddDays(-365);
            var temp = from row in _attendanceContext.h_leave_record
                       where row.startTime >= last_year_day
                       select row;
            return temp;
        }

        // HTTP GET 方法，根據指定年份和月份取得加班記錄
        [HttpGet("get_overtime_record_by_year_month")]
        public IEnumerable<h_overtime_record> get_overtime_record_by_year_month(int year, int month)
        {
            // 查詢指定年月的加班記錄
            var temp = from row in _attendanceContext.h_overtime_record
                       where row.startTime.Year == year && row.startTime.Month == month
                       select row;
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，取得當天最後的出勤狀態
        [HttpGet("get_attendannce_last_status")]
        public attendance_last_statusDTO get_attendannce_last_status(string userid)
        {
            // 查詢當天的出勤記錄，按時間排序，取最新的記錄
            var attendanceStatus = (from row in _attendanceContext.h_attendance_record
                                    where row.create_time.Date == DateTime.Now.Date && row.user_id == userid
                                    orderby row.create_time descending
                                    select new attendance_last_statusDTO { attendance_status = row.attendance_status })
                                   .FirstOrDefault();

            // 如果沒有找到出勤記錄，則查詢請假記錄
            if (attendanceStatus == null)
            {
                attendanceStatus = (from row in _attendanceContext.h_leave_record
                                    where row.startTime.Date == DateTime.Now.Date && row.userId == userid
                                    select new attendance_last_statusDTO { attendance_status = row.leaveType })
                                   .FirstOrDefault();
            }

            // 返回出勤或請假狀態
            return attendanceStatus;
        }

        // HTTP GET 方法，取得同休人員的休假表
        [HttpGet("get_person_vacation")]
        public IEnumerable<r_person_vacation> get_person_vacation()
        {
            // 返回所有同休人員的休假記錄
            return _attendanceContext.r_person_vacation.ToList();
        }

        // HTTP GET 方法，取得使用者角色和權限資訊
        [HttpGet("get_permissions_infor")]
        public IEnumerable<permissions_inforDTO> get_permissions_infor()
        {
            // 查詢使用者角色和對應的權限資訊
            var temp = from row in _attendanceContext.c_user_roles
                       select new permissions_inforDTO { role_name = row.role_name, permissions = row.permissions };
            // 返回查詢結果
            return temp;
        }

        // HTTP GET 方法，取得等待簽核加班紀錄資訊
        [HttpGet("waiting_for_approval_of_overtime_record")]
        public IEnumerable<h_overtime_record> waiting_for_approval_of_overtime_record()
        {
            var temp = from row in _attendanceContext.h_overtime_record
                       where row.approved_by == null  // 篩選 approved_by 為 null 的紀錄
                       select row;
            return temp;
        }

        // HTTP GET 方法，取得等待簽核休假紀錄資訊
        [HttpGet("waiting_for_approval_of_leave_record")]
        public IEnumerable<h_leave_record> waiting_for_approval_of_leave_record()
        {
            var temp = from row in _attendanceContext.h_leave_record
                       where row.approved_by == null  // 篩選 approved_by 為 null 的紀錄
                       select row;
            return temp;
        }

        [HttpPut("UpdateAttendanceTimes/{id}")]
        // 定義一個 HTTP PUT 方法，用於更新指定 ID 的考勤時間
        public async Task<IActionResult> UpdateAttendanceTimes(int id, [FromBody] c_attendance_times value)
        {
            // 從資料庫中查找對應的考勤紀錄，根據傳入的 ID 進行查找
            var update = await _attendanceContext.c_attendance_times
                .SingleOrDefaultAsync(a => a.id == id);

            // 如果找到對應的紀錄
            if (update != null)
            {
                // 更新上班開始時間
                update.work_start_time = value.work_start_time;
                // 更新下班時間
                update.work_end_time = value.work_end_time;
                // 更新午餐開始時間
                update.lunch_start_time = value.lunch_start_time;
                // 更新午餐結束時間
                update.lunch_end_time = value.lunch_end_time;
                // 設定更新的時間戳記為當前時間
                update.updated_at = DateTime.Now;

                try
                {
                    // 將修改保存至資料庫
                    await _attendanceContext.SaveChangesAsync();
                    return NoContent(); // 返回 204 無內容表示更新成功
                }
                catch (DbUpdateException ex)
                {
                    // 捕獲資料庫更新異常，並返回 500 伺服器錯誤，附帶異常訊息
                    return StatusCode(500, ex.Message);
                }
            }
            // 如果沒有找到對應的紀錄，返回 404 找不到的回應
            return NotFound();
        }


        // PUT: api/attendance/update_attendance_calendar
        [HttpPut("update_attendance_calendar")]
        public async Task<IActionResult> UpdateAttendanceCalendar([FromBody] c_attendance_calendar c_Attendance_Calendar)
        {
            // 驗證資料是否存在
            var existingRecord = await _attendanceContext.c_attendance_calendar
                .FirstOrDefaultAsync(ac => ac.calendar_year == c_Attendance_Calendar.calendar_year
                                          && ac.calendar_month == c_Attendance_Calendar.calendar_month);

            if (existingRecord == null)
            {
                return NotFound("該紀錄不存在。");
            }

            // 更新 attendance_days 欄位
            existingRecord.attendance_days = c_Attendance_Calendar.attendance_days;

            // 儲存變更
            await _attendanceContext.SaveChangesAsync();

            return NoContent(); // 更新成功，回傳204 No Content
        }

        //

        [HttpPut("update-overtime/{userID}/{overtimeType}/{startTime}")]
        public async Task<IActionResult> UpdateOvertimeRecord(string userID, string overtimeType, DateTime startTime, [FromBody] h_overtime_record updatedRecord)
        {
            // 查找加班記錄
            var existingRecord = await _attendanceContext.h_overtime_record
                .FirstOrDefaultAsync(o => o.userID == userID && o.overtimeType == overtimeType && o.startTime == startTime);

            if (existingRecord == null)
            {
                return NotFound("加班記錄未找到。");
            }

            // 更新資料
            existingRecord.approved_by = updatedRecord.approved_by;

            // 保存更改
            await _attendanceContext.SaveChangesAsync();

            return Ok(existingRecord);
        }

        [HttpPut("update-leave/{userId}/{leaveType}/{startTime}")]
        public async Task<IActionResult> UpdateLeaveRecord(string userId, string leaveType, DateTime startTime, [FromBody] h_leave_record updatedRecord)
        {
            // 查找請假記錄
            var existingRecord = await _attendanceContext.h_leave_record
                .FirstOrDefaultAsync(l => l.userId == userId && l.leaveType == leaveType && l.startTime == startTime);

            if (existingRecord == null)
            {
                return NotFound("請假記錄未找到。");
            }

            // 更新資料
            existingRecord.approved_by = updatedRecord.approved_by;

            // 保存更改
            await _attendanceContext.SaveChangesAsync();

            return Ok(existingRecord);
        }

    }
}
