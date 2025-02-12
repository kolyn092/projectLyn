using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Globalization;
using static AdminApi.AdminResponse;

namespace ProjectLyn
{
    [ApiController]
    [Route("Test/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetData()
        {
            return Ok(new { message = "success", data = "test" });
        }
    }
}
