using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{input}")]
        public string Explosion(string input)
        {
            // Insert your solution here
            // take first digit
            // get int and print int times (int.Parse(c.ToString())
            // add to string (string.join)
            var startString = "";
            var finalResult = string.Join(startString, input.Select(c => new String(c, int.Parse(c.ToString()))));
            return finalResult;
        }
    }
}