using Microsoft.AspNetCore.Mvc;
using Taller.Models;
using Taller.Services;

namespace Taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_taskService.GetAll());
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] TaskItem task)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = _taskService.Create(task);
            return Ok(response);
        }
    }
}
