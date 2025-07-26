using Scalar.AspNetCore;

namespace SeizureTrackerAPI.Startup;

public static class OpenApiConfig
{
    public static void AddOpenApiServices(this IServiceCollection services)
    {
        _ = services.AddOpenApi();
    }

    public static void UseOpenApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            _ = app.MapOpenApi();
            _ = app.MapScalarApiReference(options =>
            {
                options.Title = "Seizure Tracker";
                options.Theme = ScalarTheme.Moon;
                options.Layout = ScalarLayout.Modern;

            }
            );
        }
    }
}