using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiPracticing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class SecuredController : Controller
    {
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok("Hello From Secured Controller");
        }
    }
}