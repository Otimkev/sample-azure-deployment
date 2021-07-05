using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the tickets.");
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading ticket #{id}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating a ticket.");
        }

        [HttpPut("id")]
        public IActionResult Put(int id)
        {
            return Ok($"Updating ticket {id}.");
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok($"Destroying ticket #{id}.");
        }
    }
}