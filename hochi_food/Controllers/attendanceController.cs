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
        private readonly attendanceContext _attendanceContext; //先在全域宣告資料庫物件

        public attendanceController(attendanceContext attendanceContext) {
            _attendanceContext = attendanceContext;
        }

        [HttpPost("appendattendance_infor")]
        public void appendattendance_infor([FromBody] h_attendance_infor h_Attendance_Infor)
        {
            _attendanceContext.Add(h_Attendance_Infor);
            _attendanceContext.SaveChanges();
        }

        [HttpPost("appendattendance_day")]
        public void appendattendance_day([FromBody] h_attendance_day h_Attendance_Day)
        {
            _attendanceContext.Add(h_Attendance_Day);
            _attendanceContext.SaveChanges();
        }

        [HttpPost("appendattendance_record")]
        public void appendattendance_record([FromBody] h_attendance_record h_Attendance_Record)
        {
            _attendanceContext.Add(h_Attendance_Record);
            _attendanceContext.SaveChanges();
        }

        [HttpPost("appendleave_record")]
        public void appendleave_record([FromBody] h_leave_record h_Leave_Record)
        {
            _attendanceContext.Add(h_Leave_Record);
            _attendanceContext.SaveChanges();
        }

        [HttpPost("appendovetime_record")]
        public void appendovetime_record([FromBody] h_overtime_record h_Overtime_Record)
        {
            _attendanceContext.Add(h_Overtime_Record);
            _attendanceContext.SaveChanges();
        }

        [HttpPost("appendattendance_calendar")]
        public void appendattendance_calendar([FromBody] c_attendance_calendar c_Attendance_Calendar)
        {
            _attendanceContext.Add(c_Attendance_Calendar);
            _attendanceContext.SaveChanges();
        }

        [HttpGet("get_today_attendance_record")]
        public IEnumerable<h_attendance_record> get_today_attendance_record()
        {
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.create_time.Date == DateTime.Now.Date
                       select row;
            return temp;
        }

        [HttpGet("get_attendanceDates")]
        public IEnumerable<attendanceDatesDTO> get_attendanceDates(string userid,int attendanceyear,int attendancemonth)
        {
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.user_id == userid && row.create_time.Year == attendanceyear && row.create_time.Month == attendancemonth && row.attendance_status =="到班"
                       select new attendanceDatesDTO { attendanceDates = row.create_time.ToString("yyyy-MM-dd") };
            return temp.Distinct();
        }

        [HttpGet("get_attendanceDays")]
        public IEnumerable<get_attendanceDaysDTO> get_attendanceDays(int calendaryear, int calendarmonth)
        {
            var temp = from row in _attendanceContext.c_attendance_calendar
                       where row.calendar_year == calendaryear && row.calendar_month == calendarmonth
                       select new get_attendanceDaysDTO { attendance_days =row.attendance_days};
            return temp;
        }

        [HttpGet("get_today_check_in_time")]
        public IEnumerable<get_today_check_in_timeDTO> get_today_check_in_time()
        {
            string today_date = DateTime.Now.ToString("yyyy-MM-dd"); // LINQ內不能有方法@@
            var temp = from row in _attendanceContext.h_attendance_record
                       where row.create_time >= Convert.ToDateTime(today_date + " 00:00:00") && row.attendance_status == "到班"
                       orderby row.create_time descending
                       select new get_today_check_in_timeDTO { create_time=row.create_time };
            return temp;
        }

        [HttpGet("get_attendance_record_by_date")]
        public IEnumerable<attendance_recordDTO> get_attendance_record(string userid, string attendanceDate)
        {
            var temp = from row in _attendanceContext.h_attendance_record
                       where userid == row.user_id && row.create_time.Date == DateTime.Parse(attendanceDate).Date
                       orderby row.create_time
                       select new attendance_recordDTO { user_id = row.user_id, user_name = row.user_name, attendance_status = row.attendance_status, create_time = row.create_time };
            return temp;

        }

        [HttpGet("get_attendance_record")]
        public IEnumerable<attendance_recordDTO> get_attendance_record(string userid,DateTime startdate, DateTime enddate)
        {
            var temp = from row in _attendanceContext.h_attendance_record
                       where userid == row.user_id && row.create_time >= startdate && row.create_time <= enddate.AddDays(1)
                       orderby row.create_time
                       select new attendance_recordDTO { user_id=row.user_id,user_name=row.user_name, attendance_status=row.attendance_status , create_time =row.create_time};
            return temp;

        }

        [HttpGet("get_leave_record")]
        public IEnumerable<h_leave_record> get_leave_record(string userid, DateTime startdate, DateTime enddate)
        {
            var temp = from row in _attendanceContext.h_leave_record
                       where userid== row.userId && row.startTime.Date >= startdate && row.startTime.Date <= enddate && row.endTime.Date >= startdate && row.endTime.Date <= enddate
                       select new h_leave_record { userId=row.userId, userName=row.userName, leaveType=row.leaveType, startTime=row.startTime, endTime=row.endTime, count_hours=row.count_hours};
            return temp;
        }

        [HttpGet("get_leave_record_by_year_month")]
        public IEnumerable<h_leave_record> get_leave_record_by_year_month(int  year, int month)
        {
            var temp = from row in _attendanceContext.h_leave_record
                       where row.startTime.Year == year && row.startTime.Month == month
                       select row;
            return temp;    
        }

        [HttpGet("get_overtime_record_by_year_month")]
        public IEnumerable<h_overtime_record> get_overtime_record_by_year_month(int year,int month)
        {
            var temp = from row in _attendanceContext.h_overtime_record
                       where row.startTime.Year==year && row.startTime.Month == month
                       select row;
            return temp;
        }

    }
}
