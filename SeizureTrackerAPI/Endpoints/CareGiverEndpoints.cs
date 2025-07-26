using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Endpoints;

public static class CareGiverEndpoints
{
    public static void AddCareGiverEndpoints(this WebApplication app)
    {
        _ = app.MapGet("/caregivers", LoadAllCareGivers);
        _ = app.MapGet("/caregivers/{id}", LoadCareGiverById);
    }



    private static IResult LoadAllCareGivers(CareGiverData data)
    {
        return Results.Ok(data.CareGivers);
    }

    private static IResult LoadCareGiverById(CareGiverData data, Guid id)
    {
        Models.CareGiver? output = data.CareGivers.FirstOrDefault(c => c.CareGiverID == id);

        if (output is null)
        {
            return Results.NotFound();
        }

        return Results.Ok(output);
    }
}
