using AutoMapper;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskItem, TaskResponseDTO>().ReverseMap();
            CreateMap<TaskCreateDTO, TaskItem>().ReverseMap();
            CreateMap<TaskUpdateDTO, TaskItem>().ReverseMap();
        }
    }
}