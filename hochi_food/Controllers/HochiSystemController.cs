using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics;

namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class HochiSystemController : ControllerBase
    {
        private readonly HochiSystemContext _hochiSystemContext;   //先在全域宣告資料庫物件

        public HochiSystemController(HochiSystemContext hochisystemcontext)
        {
            _hochiSystemContext = hochisystemcontext;
        }
    }
}
