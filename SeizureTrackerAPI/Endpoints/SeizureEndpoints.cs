using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Endpoints;

public static class SeizureEndpoints
{
    public static void AddSeizureEndpoints(this WebApplication app)
    {
        _ = app.MapGet("/Seizures", LoadAllSeizures);
        _ = app.MapGet("/Seizures/{id}", LoadSeizureById);
        _ = app.MapPost("/Seizures/create", CreateSeizure);
    }

    private static IResult LoadAllSeizures(SeizureData data)
    {
        return Results.Ok(data.seizures);
    }

    private static IResult LoadSeizureById(
        SeizureData data,
        Guid id)
    {
        Models.Seizures? output = data.seizures.FirstOrDefault(c => c.SeizureEventId == id);

        if (output is null)
        {
            return Results.NotFound();
        }

        return Results.Ok(output);
    }

    private static IResult CreateSeizure(
        SeizureData data,
        Models.Seizures Seizure)
    {
        if (Seizure is null)
        {
            return Results.BadRequest("Seizure data is required.");
        }
        Seizure.SeizureEventId = Guid.NewGuid();
        data.seizures.Add(Seizure);
        data.WriteSeizureData();
        return Results.Created($"/Seizures/{Seizure.SeizureEventId}", Seizure);
    }
}
