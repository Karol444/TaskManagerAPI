using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Services.Interfaces;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _service;

        public TasksController(ITaskService service)
        {
            _service = service;
        }

       
        [HttpPost]
        [ProducesResponseType(typeof(TaskResponseDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TaskResponseDTO>> Create([FromBody] TaskCreateDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _service.CreateTaskAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<TaskResponseDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TaskResponseDTO>>> GetAll()
        {
            return Ok(await _service.GetAllTasksAsync());
        }

        [HttpGet("status/{status}")]
        [ProducesResponseType(typeof(IEnumerable<TaskResponseDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TaskResponseDTO>>> GetByStatus(Enums.TaskStatus status)
        {
            return Ok(await _service.GetTasksByStatusAsync(status));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TaskResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TaskResponseDTO>> GetById(int id)
        {
            var tasks = await _service.GetAllTasksAsync();
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();
            return Ok(task);
        }

     
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TaskResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TaskResponseDTO>> Update(int id, [FromBody] TaskUpdateDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var result = await _service.UpdateTaskAsync(id, dto);
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _service.DeleteTaskAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}