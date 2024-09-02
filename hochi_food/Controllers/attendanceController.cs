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
        private readonly attendanceContext _attendanceContext;

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

        [HttpGet("get_attendance_record")]
        public IEnumerable<attendance_recordDTO> get_attendance_record(string userid,DateTime startdate, DateTime enddate)
        {
            var temp = from row in _attendanceContext.h_attendance_record
                       where userid == row.user_id && row.create_time >= startdate && row.create_time <= enddate
                       select new attendance_recordDTO { user_id=row.user_id,user_name=row.user_name, attendance_status=row.attendance_status , create_time =row.create_time};
            return temp;

        }

    }
}
