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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{s}")]
        public String Accum(string s)
        {
            // your code
            // string.Join ("-", blahblah) to put - between parts
            // example: third letter = A -> Aaa (index =2)
            // first letter to upper
            // after that, to lower for index number of times 
            return string.Join("-", s.Select((c, i) => new String((char.ToUpper(c) + new String(char.ToLower(c), i)))));
        }
    }
}