using Microsoft.Extensions.DependencyInjection;
using MyDiaryAPI.Services.Services.NoteService;

namespace MyDiaryAPI.Services;

public static class Extensions
{

    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();
    }
    
    public static void AddRequestAutoMapperProfile(this IServiceCollection services) => services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
}