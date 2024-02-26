using AutoMapper;
using MyDiaryAPI.Domain.Models;
using MyDiaryAPI.Services.Requests;

namespace MyDiaryAPI.Services.MapperProfile;

public class RequestMapperProfile : Profile
{
    public RequestMapperProfile()
    {
        CreateMap<CreateNote, Note>()
            .ForMember(x => x.Title, opts => opts.MapFrom(x => x.Title))
            .ForMember(x => x.Content, opts => opts.MapFrom(x => x.Content))
            .ForMember(x => x.Date, opts => opts.MapFrom(x => x.Date));
        
        CreateMap<UpdateNote, Note>()
            .ForMember(x => x.Title, opts => opts.MapFrom(x => x.Title))
            .ForMember(x => x.Content, opts => opts.MapFrom(x => x.Content))
            .ForMember(x => x.Date, opts => opts.MapFrom(x => x.Date))
            .ForMember(x => x.Id, opts => opts.MapFrom(x => x.Id));

    }
}