using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyDiaryAPI.Persistance.Repositories;

namespace MyDiaryAPI.Persistance;

public static class Extensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<INotesRepository, NotesRepository>();
    }

    public static void AddDataContext(this IServiceCollection services)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer("ConnectionString");
        });
    }
    public static void Migrate(this IApplicationBuilder app) => MigrationManager.MigrationInitialization(app);
}