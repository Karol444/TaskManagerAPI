using System.ComponentModel.DataAnnotations;
using TaskManagerAPI.Enums;

namespace TaskManagerAPI.DTOs
{
    public class TaskUpdateDTO
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Título deve ter entre 3 e 100 caracteres.")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public Enums.TaskStatus Status { get; set; }
    }
}