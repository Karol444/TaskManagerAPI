using AutoMapper;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Repositories.Interfaces;
using TaskManagerAPI.Services.Interfaces;

namespace TaskManagerAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TaskResponseDTO> CreateTaskAsync(TaskCreateDTO dto)
        {
            var task = _mapper.Map<Models.TaskItem>(dto);
            await _repository.AddAsync(task);
            return _mapper.Map<TaskResponseDTO>(task);
        }

        public async Task<IEnumerable<TaskResponseDTO>> GetAllTasksAsync()
        {
            var tasks = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TaskResponseDTO>>(tasks);
        }

        public async Task<IEnumerable<TaskResponseDTO>> GetTasksByStatusAsync(Enums.TaskStatus status)
        {
            var tasks = await _repository.GetByStatusAsync(status);
            return _mapper.Map<IEnumerable<TaskResponseDTO>>(tasks);
        }

        public async Task<TaskResponseDTO> UpdateTaskAsync(int id, TaskUpdateDTO dto)
        {
            var task = await _repository.GetByIdAsync(id);
            if (task == null) throw new Exception("Tarefa não encontrada.");

            _mapper.Map(dto, task);
            await _repository.UpdateAsync(task);
            return _mapper.Map<TaskResponseDTO>(task);
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _repository.GetByIdAsync(id);
            if (task == null) return false;

            await _repository.DeleteAsync(id);
            return true;
        }
    }
}