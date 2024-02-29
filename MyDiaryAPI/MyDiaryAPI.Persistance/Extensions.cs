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
        var connectionString = GetConnectionString();
        services.AddDbContext<DataContext>(options =>
        {
            options
                .UseSqlServer(connectionString);
        });
    }
    
    private static string GetConnectionString()
    {
        var databaseServer = Environment.GetEnvironmentVariable("DatabaseServer");
        var databasePort = Environment.GetEnvironmentVariable("DatabasePort");
        var databaseUser = Environment.GetEnvironmentVariable("DatabaseUser");
        var databasePassword = Environment.GetEnvironmentVariable("DatabasePassword");
        var databaseName = Environment.GetEnvironmentVariable("DatabaseName");

        var connectionString =
            $"Server={databaseServer},{databasePort};Database={databaseName};User Id={databaseUser};Password={databasePassword};TrustServerCertificate=true";
        return connectionString;
    }
    
    public static void Migrate(this IApplicationBuilder app) => MigrationManager.MigrationInitialization(app);
}