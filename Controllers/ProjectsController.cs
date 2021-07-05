using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApplication2.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok("Getting all projects.");
        }

        [HttpGet("id")]
        public IActionResult GetProjectById(int id)
        {
            return Ok($"Getting project #{id}");
        }

        [HttpGet]
        [Route("/api/projects/{pId}/tickets")]
        public IActionResult GetTicketByProject(int pId, [FromQuery]int tid)
        {
            return Ok($"Reading Project #{pId}, ticket # {tid}");
        }

        [HttpPost]
        public IActionResult PostProject()
        {
            return Ok("Creating a Project.");
        }

        [HttpPut("id")]
        public IActionResult UpdateProject(int id)
        {
            return Ok($"Updating project #{id}");
        }

        [HttpDelete("id")]
        public IActionResult DestroyProject(int id)
        {
            return Ok($"Destroying Project #{id}");
        }
    }
}