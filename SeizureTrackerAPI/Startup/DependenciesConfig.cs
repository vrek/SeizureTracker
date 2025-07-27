using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Startup;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        _ = builder.Services.AddTransient<CareGiverData>();
        builder.Services.AddCorsServices();
    }
}
