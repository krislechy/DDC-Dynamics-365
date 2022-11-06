using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DDC.WebService.Controllers
{
    [ApiController]
    [EnableCors("AllowAllPolicy")]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet(nameof(Test))]
        public IActionResult Test()
        {
            return Ok("is test ok");
        }
    }
}
