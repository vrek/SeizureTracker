using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Endpoints;

public static class CareGiverEndpoints
{
    public static void AddCareGiverEndpoints(this WebApplication app)
    {
        _ = app.MapGet("/caregivers", LoadAllCareGivers);
        _ = app.MapGet("/caregivers/{id}", LoadCareGiverById);
        _ = app.MapGet("/caregivers/{firstname}/{lastname}", LoadCareGiverByName);
        _ = app.MapPost("/caregivers/create", CreateCareGiver);
    }

    private static async Task<IResult> LoadAllCareGivers(CareGiverAccess data)
    {
        return await data.LoadAllCareGivers();
    }


    private static IResult LoadCareGiverById(CareGiverAccess data, Guid id)
    {
        return data.LoadCareGiverById(id);
    }

    private static IResult LoadCareGiverByName(CareGiverAccess data, string? firstname, string? lastname)
    {
        return data.LoadCareGiverByName(firstname, lastname);
    }

    private static IResult CreateCareGiver(CareGiverAccess data, Models.Caregiver careGiver)
    {
        return data.CreateCareGiver(careGiver);
    }
}
