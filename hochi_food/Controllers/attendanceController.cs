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
            // 查詢指定使用者在指定年月的出勤日期，並篩選出"到班"的狀態
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.user_id == userid && row.create_time.Year == attendanceyear && row.create_time.Month == attendancemonth && row.attendance_status == "到班"
                       select new attendanceDatesDTO { attendanceDates = row.create_time.ToString("yyyy-MM-dd") };
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

        // 更新上下班時間
        [HttpPut("updateWorkTimes/{id}")]
        public async Task<IActionResult> UpdateWorkTimes(int id, [FromBody] TimeSpan workStart, TimeSpan workEnd)
        {
            // 從資料庫查找現有的記錄
            var existingRecord = await _attendanceContext.c_attendance_times.FindAsync(id);
            if (existingRecord == null)
            {
                return NotFound(); // 若找不到記錄，返回 404
            }

            // 更新上下班時間
            existingRecord.work_start_time = workStart;
            existingRecord.work_end_time = workEnd;

            // 設置最後更新時間為當前時間
            existingRecord.updated_at = DateTime.Now;

            // 保存變更到資料庫
            await _attendanceContext.SaveChangesAsync();

            // 返回更新後的記錄
            return Ok(existingRecord);
        }

        //更新休息時間 lunch_start_time lunch_end_time
        [HttpPut("updateLunchTimes/{id}")]
        public async Task<IActionResult> UpdateLunchTimes(int id, [FromBody] TimeSpan lunch_start_time, TimeSpan lunch_end_time)
        {
            // 從資料庫查找現有的記錄
            var existingRecord = await _attendanceContext.c_attendance_times.FindAsync(id);
            if (existingRecord == null)
            {
                return NotFound(); // 若找不到記錄，返回 404
            }

            // 更新上下班時間
            existingRecord.lunch_start_time = lunch_start_time;
            existingRecord.lunch_end_time = lunch_end_time;

            // 設置最後更新時間為當前時間
            existingRecord.updated_at = DateTime.Now;

            // 保存變更到資料庫
            await _attendanceContext.SaveChangesAsync();

            // 返回更新後的記錄
            return Ok(existingRecord);
        }

    }
}
