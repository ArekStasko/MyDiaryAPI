using Microsoft.Extensions.DependencyInjection;

namespace MyDiaryAPI.Domain;

public static class Extensions
{
    public static void AddAutomapperProfile(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}