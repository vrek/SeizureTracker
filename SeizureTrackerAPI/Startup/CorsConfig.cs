namespace SeizureTrackerAPI.Startup;

public static class CorsConfig
{
    private const string AllowAllPolicy = "AllowAll";
    public static void AddCorsServices(this IServiceCollection services)
    {
        _ = services.AddCors(options =>
        {
            options.AddPolicy("AllowAllPolicy",
                policy =>
                {
                    _ = policy.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
        }
        );
    }

    public static void ApplyCorsConfig(this WebApplication app)
    {
        _ = app.UseCors("AllowAllPolicy");
    }
}
