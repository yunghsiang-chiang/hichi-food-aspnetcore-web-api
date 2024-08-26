using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;

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

        //public IActionResult Index()
        //{
        //    return View();
        //}

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
    }
}
