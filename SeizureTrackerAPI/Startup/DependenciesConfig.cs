using Microsoft.EntityFrameworkCore;
using SeizureTrackerAPI.Context;
using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Startup;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        _ = builder.Services.AddScoped<CareGiverAccess>();
        _ = builder.Services.AddScoped<PatientDataAccess>();
        _ = builder.Services.AddScoped<SeizureData>();
        _ = builder.Services.AddSingleton<SeizureData>();
        builder.Services.AddCorsServices();

        IServiceCollection context = builder.Services.AddDbContext<DBContext>(options =>
        {
            _ = options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
    }
}

