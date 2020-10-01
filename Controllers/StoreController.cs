using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        [HttpPost("a")]
        public string Index([FromForm(Name = "file")] IFormFile file, [FromForm] string p)
        {
            //var s = p + "AA";
            string s;
            if (file != null || file.Length != 0)
            {
                s = "OK" + p;
            }
            else
            {
                s = "Not OK";
            }
            return s;
        }
    }
}
