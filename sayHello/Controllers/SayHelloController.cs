using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace sayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {

        [HttpGet]
        [Route("Name/{userName}")]
        public string Name(string userName)
        {
            return $"Hello, {userName}!";
        }
    }
}