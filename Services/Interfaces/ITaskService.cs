using TaskManagerAPI.DTOs;

namespace TaskManagerAPI.Services.Interfaces
{
    public interface ITaskService
    {
        Task<TaskResponseDTO> CreateTaskAsync(TaskCreateDTO dto);
        Task<IEnumerable<TaskResponseDTO>> GetAllTasksAsync();
        Task<IEnumerable<TaskResponseDTO>> GetTasksByStatusAsync(Enums.TaskStatus status);
        Task<TaskResponseDTO> UpdateTaskAsync(int id, TaskUpdateDTO dto);
        Task<bool> DeleteTaskAsync(int id);
    }
}