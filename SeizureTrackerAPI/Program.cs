using SeizureTrackerAPI.Endpoints;
using SeizureTrackerAPI.Startup;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

WebApplication app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();
app.ApplyCorsConfig();


app.AddRootEndpoints();
app.AddCareGiverEndpoints();
app.AddPatientEndpoints();
app.AddSeizureEndpoints();

app.Run();
