using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApi
{
    [ApiController]
    [Route("InHouse/[action]")]
    public class InHouseController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData(AdminRequest.SendData data)
        {
            var resData = new List<string>();
            if(data.Data == 0)
            {
                resData.Add("test string");
            }

            var result = new AdminResponse.GetData()
            {
                Result = new AdminResponse.Result() { Code = 0, Message = string.Empty },
                Data = resData,
            };

            return new JsonResult(result);
        }
    }
}
