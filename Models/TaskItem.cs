using TaskManagerAPI.Enums;

namespace TaskManagerAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.Pendente;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}