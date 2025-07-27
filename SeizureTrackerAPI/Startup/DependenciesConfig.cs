using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Startup;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        _ = builder.Services.AddSingleton<CareGiverData>();
        _ = builder.Services.AddSingleton<PatientData>();
        builder.Services.AddCorsServices();
    }
}
