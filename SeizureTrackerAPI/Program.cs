using SeizureTrackerAPI.Endpoints;
using SeizureTrackerAPI.Startup;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

WebApplication app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.AddRootEndpoints();
app.AddCareGiverEndpoints();

app.Run();
