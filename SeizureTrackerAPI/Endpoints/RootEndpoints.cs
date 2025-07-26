namespace SeizureTrackerAPI.Endpoints;

public static class RootEndpoints
{
    public static void AddRootEndpoints(this WebApplication app)
    {
        _ = app.MapGet("/", () => "Hello World!");
    }
}
