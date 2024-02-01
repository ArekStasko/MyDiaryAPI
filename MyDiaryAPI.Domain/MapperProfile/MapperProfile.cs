using AutoMapper;
using MyDiaryAPI.Domain.DTO;
using MyDiaryAPI.Domain.Models;

namespace MyDiaryAPI.Domain.MapperProfile;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Note, NoteDto>();
    }
}