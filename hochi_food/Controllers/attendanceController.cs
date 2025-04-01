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
        private readonly hochi_configContext _hochi_configContext;

        // 建構函式，將 attendanceContext 的實例注入到控制器中
        public attendanceController(attendanceContext attendanceContext, hochi_configContext hochi_configContext)
        {
            // 將注入的 attendanceContext 賦值給私有變數 _attendanceContext
            _attendanceContext = attendanceContext;
            _hochi_configContext = hochi_configContext;
        }

        // 建構函式，將 hochi_configContext 的實例注入到控制器中

        // HTTP POST 方法，新增出勤資訊記錄
        [HttpPost("appendattendance_infor")]
        public void appendattendance_infor([FromBody] h_attendance_infor h_Attendance_Infor)
        {
            // 將出勤資訊新增到資料庫
            _attendanceContext.Add(h_Attendance_Infor);
            // 保存變更
            _attendanceContext.SaveChanges();
        }

        // HTTP POST 方法，新增或覆蓋每日出勤記錄
        [HttpPost("appendattendance_day")]
        public IActionResult appendattendance_day([FromBody] h_attendance_day h_Attendance_Day)
        {
            try
            {
                // 先檢查資料是否已經存在
                var existingRecord = _attendanceContext.h_attendance_day
                    .FirstOrDefault(a => a.user_id == h_Attendance_Day.user_id && a.attendance_day == h_Attendance_Day.attendance_day);

                if (existingRecord != null)
                {
                    // 如果存在，更新現有資料
                    existingRecord.user_name = h_Attendance_Day.user_name;
                    existingRecord.morning_light_up = h_Attendance_Day.morning_light_up;
                    existingRecord.morning_light_down = h_Attendance_Day.morning_light_down;
                    existingRecord.morning_meeting = h_Attendance_Day.morning_meeting;
                    existingRecord.morning_light_down_after_purple_light = h_Attendance_Day.morning_light_down_after_purple_light;
                }
                else
                {
                    // 如果不存在，新增新的記錄
                    _attendanceContext.h_attendance_day.Add(h_Attendance_Day);
                }

                // 保存變更
                _attendanceContext.SaveChanges();

                // 成功操作，不回傳任何數據 (204 No Content)
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                // 異常時回傳500 Internal Server Error，並附帶錯誤訊息和傳入的資料
                return StatusCode(500, new { error = $"Internal server error: {ex.Message}", data = h_Attendance_Day });
            }
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
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [HttpGet("GetAttendanceSummary")]
        public async Task<IActionResult> GetAttendanceSummary(DateTime startDate, DateTime endDate)
        {
            // 獲取基本同修資料
            var baseData = await _hochi_configContext.c_fellow_hochi_learners
                .Where(hcl => hcl.person_type != "group")
                .Select(hcl => new
                {
                    hcl.person_id,
                    hcl.person_name
                }).ToListAsync();

            // 獲取出勤記錄
            var attendanceData = await _attendanceContext.h_attendance_record
                .Where(ar => ar.create_time >= startDate && ar.create_time <= endDate &&
                             (ar.attendance_status == "到班" || ar.attendance_status == "外出公務"))
                .GroupBy(ar => ar.user_id)
                .Select(g => new
                {
                    User_id = g.Key,
                    attendance_days = g.Count()
                }).ToListAsync();

            // 獲取晨光和晨會記錄
            var meetingData = await _attendanceContext.h_attendance_day
                .Where(ad => ad.attendance_day >= startDate && ad.attendance_day <= endDate)
                .GroupBy(ad => ad.user_id)
                .Select(g => new
                {
                    user_id = g.Key,
                    morning_meeting = g.Sum(x => x.morning_meeting),
                    morning_light_up = g.Sum(x => x.morning_light_up),
                    morning_light_down = g.Sum(x => x.morning_light_down),
                    morning_light_down_after_purple_light = g.Sum(x=>x.morning_light_down_after_purple_light)
                }).ToListAsync();

            // 獲取病假記錄
            var sickLeaveData = await _attendanceContext.h_leave_record
                .Where(lr => lr.startTime >= startDate && lr.endTime <= endDate && lr.leaveType == "病假")
                .GroupBy(lr => lr.userId)
                .Select(g => new
                {
                    userid = g.Key,
                    sick_hours = g.Sum(x => x.count_hours)
                }).ToListAsync();

            // 其他請假類型同樣的方式
            var personalLeaveData = await _attendanceContext.h_leave_record
                .Where(lr => lr.startTime >= startDate && lr.endTime <= endDate && lr.leaveType == "事假")
                .GroupBy(lr => lr.userId)
                .Select(g => new
                {
                    userid = g.Key,
                    personal_hours = g.Sum(x => x.count_hours)
                }).ToListAsync();

            var annualLeaveData = await _attendanceContext.h_leave_record
                .Where(lr => lr.startTime >= startDate && lr.endTime <= endDate && lr.leaveType == "特休")
                .GroupBy(lr => lr.userId)
                .Select(g => new
                {
                    userid = g.Key,
                    annual_hours = g.Sum(x => x.count_hours)
                }).ToListAsync();

            var compLeaveData = await _attendanceContext.h_leave_record
                .Where(lr => lr.startTime >= startDate && lr.endTime <= endDate && lr.leaveType == "補休")
                .GroupBy(lr => lr.userId)
                .Select(g => new
                {
                    userid = g.Key,
                    comp_hours = g.Sum(x => x.count_hours)
                }).ToListAsync();

            var overtimeData = await _attendanceContext.h_overtime_record
                .Where(or => or.startTime >= startDate && or.endTime <= endDate)
                .GroupBy(or => or.userID)
                .Select(g => new
                {
                    userID = g.Key,
                    overtime_hours = g.Sum(x => x.count_hours)
                }).ToListAsync();

            // 將所有數據合併
            var result = baseData.Select(hcl => new
            {
                User_id = hcl.person_id,
                Name = hcl.person_name,
                出勤 = attendanceData.FirstOrDefault(a => a.User_id == hcl.person_id)?.attendance_days ?? 0,
                晨會 = meetingData.FirstOrDefault(m => m.user_id == hcl.person_id)?.morning_meeting ?? 0,
                晨光上 = meetingData.FirstOrDefault(m => m.user_id == hcl.person_id)?.morning_light_up ?? 0,
                晨光下 = meetingData.FirstOrDefault(m => m.user_id == hcl.person_id)?.morning_light_down ?? 0,
                晨下煉完紫光系 = meetingData.FirstOrDefault(m=>m.user_id == hcl.person_id)?.morning_light_down_after_purple_light ?? 0,
                病假 = sickLeaveData.FirstOrDefault(s => s.userid == hcl.person_id)?.sick_hours ?? 0,
                事假 = personalLeaveData.FirstOrDefault(p => p.userid == hcl.person_id)?.personal_hours ?? 0,
                特休 = annualLeaveData.FirstOrDefault(a => a.userid == hcl.person_id)?.annual_hours ?? 0,
                補休 = compLeaveData.FirstOrDefault(c => c.userid == hcl.person_id)?.comp_hours ?? 0,
                加班 = overtimeData.FirstOrDefault(o => o.userID == hcl.person_id)?.overtime_hours ?? 0
            }).ToList();

            return Ok(result);
        }

        // HTTP GET 方法，取得特定同修在某年某月的累積晨光與晨會數據
        [HttpGet("getMonthlyAttendanceSummary")]
        public IActionResult GetMonthlyAttendanceSummary(string user_id, int year, int month)
        {
            try
            {
                // 篩選符合 user_id 和指定年份與月份的出勤記錄
                var attendanceRecords = _attendanceContext.h_attendance_day
                    .Where(a => a.user_id == user_id
                                && a.attendance_day.Year == year
                                && a.attendance_day.Month == month)
                    .ToList();

                // 計算當月累積的晨光上、晨光下、晨會數據
                var summary = new
                {
                    TotalMorningLightUp = attendanceRecords.Sum(a => a.morning_light_up),
                    TotalMorningLightDown = attendanceRecords.Sum(a => a.morning_light_down),
                    TotalMorningMeeting = attendanceRecords.Sum(a => a.morning_meeting),
                    TotalMorning_light_down_after_purple_light = attendanceRecords.Sum(a=>a.morning_light_down_after_purple_light)
                };

                // 回傳累積數據
                return Ok(summary);
            }
            catch (Exception ex)
            {
                // 異常時回傳錯誤訊息
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("getMonthlyAttendance")]
        public IActionResult GetMonthlyAttendance(string user_id, int year, int month)
        {
            try
            {
                // 篩選符合 user_id 和指定年份與月份的出勤記錄
                var attendanceRecords = _attendanceContext.h_attendance_day
                    .Where(a => a.user_id == user_id
                                && a.attendance_day.Year == year
                                && a.attendance_day.Month == month)
                    .ToList();

                // 回傳累積數據
                return Ok(attendanceRecords);
            }
            catch (Exception ex)
            {
                // 異常時回傳錯誤訊息
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
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
            // 確保 enddate 為該日的結束時間
            DateTime endOfEndDate = enddate.Date.AddDays(1).AddTicks(-1);

            // 查詢指定使用者在指定時間範圍內的加班記錄
            var temp = from row in _attendanceContext.h_overtime_record
                       where userid == row.userID && row.startTime.Date >= startdate.Date && row.endTime <= endOfEndDate
                       select row;

            // 返回查詢結果
            return temp;

        }

        // HTTP GET 方法，根據使用者 ID 和指定時間範圍取得請假記錄
        [HttpGet("get_leave_record")]
        public IEnumerable<h_leave_record> get_leave_record(string userid, DateTime startdate, DateTime enddate)
        {
            // 將 enddate 設為當日的結束時間
            DateTime endOfEndDate = enddate.Date.AddDays(1).AddTicks(-1);

            // 查詢指定使用者在指定時間範圍內的請假記錄
            var temp = from row in _attendanceContext.h_leave_record
                       where userid == row.userId && row.startTime.Date >= startdate.Date && row.endTime <= endOfEndDate
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

        [HttpGet("get_attendance_last_status")]
        public attendance_last_statusDTO get_attendance_last_status(string userid)
        {
            // 取得當天的請假記錄
            var leaveRecords = (from row in _attendanceContext.h_leave_record
                                where row.startTime.Date == DateTime.Now.Date && row.userId == userid
                                select new { LeaveType = row.leaveType, StartTime = row.startTime, EndTime = row.endTime })
                               .ToList();

            // 取得當天的出勤記錄
            var attendanceRecords = (from row in _attendanceContext.h_attendance_record
                                     where row.create_time.Date == DateTime.Now.Date && row.user_id == userid
                                     select new { Status = row.attendance_status, Time = row.create_time })
                                    .ToList();

            // 遍歷出勤記錄，排除在請假時間段內的出勤記錄
            var validAttendanceRecords = attendanceRecords.Where(attendance =>
            {
                // 檢查出勤時間是否在所有請假記錄的請假時間段之外
                bool isDuringLeave = leaveRecords.Any(leave => attendance.Time >= leave.StartTime && attendance.Time <= leave.EndTime);
                return !isDuringLeave; // 如果不在請假時間段內，則認為是有效的出勤記錄
            })
            .ToList();

            // 合併有效的出勤記錄和請假記錄，按時間排序
            var combinedRecords = validAttendanceRecords
                                  .Select(record => new { Status = record.Status, Time = record.Time })
                                  .Concat(leaveRecords.Select(leave => new { Status = leave.LeaveType, Time = leave.StartTime }))
                                  .OrderByDescending(record => record.Time)
                                  .FirstOrDefault();

            // 如果找到合併後的最新有效記錄，返回最新狀態
            if (combinedRecords != null)
            {
                return new attendance_last_statusDTO { attendance_status = combinedRecords.Status };
            }

            // 如果沒有找到任何有效記錄，返回空的狀態
            return null;
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

        // HTTP PUT 方法，刪除舊記錄並新增新記錄以更新出勤記錄
        [HttpPut("update-attendance/{user_id}/{attendance_status}/{create_time}")]
        public async Task<IActionResult> UpdateAttendanceRecord(string user_id, string attendance_status, DateTime create_time, [FromBody] h_attendance_record updatedRecord)
        {
            // 查找舊的出勤記錄
            var existingRecord = await _attendanceContext.h_attendance_record
                .FirstOrDefaultAsync(a => a.user_id == user_id && a.attendance_status == attendance_status && a.create_time == create_time);

            if (existingRecord == null)
            {
                return NotFound("出勤記錄未找到。");
            }

            // 刪除舊的出勤記錄
            _attendanceContext.h_attendance_record.Remove(existingRecord);

            // 新增更新後的記錄
            try
            {
                _attendanceContext.h_attendance_record.Add(updatedRecord); // 使用傳入的更新數據新增新記錄
                await _attendanceContext.SaveChangesAsync();
                return Ok(updatedRecord); // 返回新增後的記錄
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"更新失敗：{ex.Message}");
            }
        }

        // 更新請假記錄 (刪除舊記錄，新增新記錄)
        [HttpPut("replace-leave-record/{userId}/{leaveType}/{startTime}")]
        public async Task<IActionResult> ReplaceLeaveRecord(string userId, string leaveType, DateTime startTime, [FromBody] h_leave_record updatedLeaveRecord)
        {
            // 查找舊的請假記錄
            var existingLeaveRecord = await _attendanceContext.h_leave_record
                .FirstOrDefaultAsync(l => l.userId == userId && l.leaveType == leaveType && l.startTime == startTime);

            if (existingLeaveRecord == null)
            {
                return NotFound("請假記錄未找到。");
            }

            // 刪除舊記錄
            _attendanceContext.h_leave_record.Remove(existingLeaveRecord);

            // 新增新記錄
            try
            {
                _attendanceContext.h_leave_record.Add(updatedLeaveRecord);
                await _attendanceContext.SaveChangesAsync();
                return Ok(updatedLeaveRecord);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"更新失敗：{ex.Message}");
            }
        }

        // 更新加班記錄 (刪除舊記錄，新增新記錄)
        [HttpPut("replace-overtime-record/{userID}/{startTime}")]
        public async Task<IActionResult> ReplaceOvertimeRecord(string userID, DateTime startTime, [FromBody] h_overtime_record updatedOvertimeRecord)
        {
            // 查找舊的加班記錄
            var existingOvertimeRecord = await _attendanceContext.h_overtime_record
                .FirstOrDefaultAsync(o => o.userID == userID && o.startTime == startTime);

            if (existingOvertimeRecord == null)
            {
                return NotFound("加班記錄未找到。");
            }

            // 刪除舊記錄
            _attendanceContext.h_overtime_record.Remove(existingOvertimeRecord);

            // 新增新記錄
            try
            {
                _attendanceContext.h_overtime_record.Add(updatedOvertimeRecord);
                await _attendanceContext.SaveChangesAsync();
                return Ok(updatedOvertimeRecord);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"更新失敗：{ex.Message}");
            }
        }

        // 刪除出勤記錄
        [HttpDelete("delete-attendance-record/{user_id}/{attendance_status}/{create_time}")]
        public async Task<IActionResult> DeleteAttendanceRecord(string user_id, string attendance_status, DateTime create_time)
        {
            var record = await _attendanceContext.h_attendance_record
                .FirstOrDefaultAsync(a => a.user_id == user_id && a.attendance_status == attendance_status && a.create_time == create_time);

            if (record == null)
            {
                return NotFound("出勤記錄未找到。");
            }

            _attendanceContext.h_attendance_record.Remove(record);
            await _attendanceContext.SaveChangesAsync();

            return NoContent();
        }

        // 刪除請假記錄
        [HttpDelete("delete-leave-record/{userId}/{leaveType}/{startTime}")]
        public async Task<IActionResult> DeleteLeaveRecord(string userId, string leaveType, DateTime startTime)
        {
            var record = await _attendanceContext.h_leave_record
                .FirstOrDefaultAsync(l => l.userId == userId && l.leaveType == leaveType && l.startTime == startTime);

            if (record == null)
            {
                return NotFound("請假記錄未找到。");
            }

            _attendanceContext.h_leave_record.Remove(record);
            await _attendanceContext.SaveChangesAsync();

            return NoContent();
        }

        // 刪除加班記錄
        [HttpDelete("delete-overtime-record/{userID}/{startTime}")]
        public async Task<IActionResult> DeleteOvertimeRecord(string userID, DateTime startTime)
        {
            var record = await _attendanceContext.h_overtime_record
                .FirstOrDefaultAsync(o => o.userID == userID && o.startTime == startTime);

            if (record == null)
            {
                return NotFound("加班記錄未找到。");
            }

            _attendanceContext.h_overtime_record.Remove(record);
            await _attendanceContext.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// 取得所有公告
        /// </summary>
        [HttpGet("GetAnnouncements")]
        public async Task<IActionResult> GetAnnouncements()
        {
            try
            {
                var announcements = await _attendanceContext.h_announcements.ToListAsync();
                return Ok(announcements);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"伺服器錯誤: {ex.Message}");
            }
        }

        /// <summary>
        /// 新增或更新公告
        /// </summary>
        [HttpPost("AddAnnouncement")]
        public async Task<IActionResult> AddAnnouncement([FromBody] h_announcements announcement)
        {
            try
            {
                if (announcement == null)
                {
                    return BadRequest("公告資料不能為空");
                }

                // 驗證必要欄位
                if (string.IsNullOrEmpty(announcement.title) || string.IsNullOrEmpty(announcement.content))
                {
                    return BadRequest("標題與內容為必填欄位");
                }

                if (announcement.announcement_id > 0) // 更新操作
                {
                    var existingAnnouncement = await _attendanceContext.h_announcements
                        .FirstOrDefaultAsync(a => a.announcement_id == announcement.announcement_id);

                    if (existingAnnouncement == null)
                    {
                        return NotFound("找不到指定的公告");
                    }

                    // 更新公告內容
                    existingAnnouncement.title = announcement.title;
                    existingAnnouncement.content = announcement.content;
                    existingAnnouncement.author = announcement.author;
                    existingAnnouncement.issue_time = announcement.issue_time;
                    existingAnnouncement.start_time = announcement.start_time;
                    existingAnnouncement.end_time = announcement.end_time;
                    existingAnnouncement.status = announcement.status;
                    existingAnnouncement.updated_at = DateTime.Now;

                    _attendanceContext.h_announcements.Update(existingAnnouncement);
                }
                else // 新增操作
                {
                    var newAnnouncement = new h_announcements
                    {
                        title = announcement.title,
                        content = announcement.content,
                        author = announcement.author,
                        issue_time = announcement.issue_time,
                        start_time = announcement.start_time,
                        end_time = announcement.end_time,
                        status = announcement.status,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };

                    await _attendanceContext.h_announcements.AddAsync(newAnnouncement);
                }

                await _attendanceContext.SaveChangesAsync();

                return Ok(announcement.announcement_id > 0 ? "公告更新成功" : "公告新增成功");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"伺服器錯誤: {ex.Message}");
            }
        }

        /// <summary>
        /// 獲取當前有效的公告列表
        /// </summary>
        /// <returns>返回符合條件的公告列表</returns>
        [HttpGet("GetPublishedAnnouncements")]
        public async Task<IActionResult> GetPublishedAnnouncements()
        {
            try
            {
                // 獲取當前有效的公告
                var publishedAnnouncements = await _attendanceContext.h_announcements
                    .Where(a => a.status == "published"
                                && a.start_time <= DateTime.Now
                                && a.end_time >= DateTime.Now)
                    .OrderByDescending(a => a.created_at)
                    .ToListAsync();

                // 如果無符合條件的公告
                if (!publishedAnnouncements.Any())
                {
                    return NotFound("目前沒有有效的公告");
                }

                return Ok(publishedAnnouncements);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"伺服器錯誤: {ex.Message}");
            }
        }


    }
}
