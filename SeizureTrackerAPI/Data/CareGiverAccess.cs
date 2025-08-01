using SeizureTrackerAPI.Context;
using SeizureTrackerAPI.DTO;
using SeizureTrackerAPI.Models;

namespace SeizureTrackerAPI.Data;

public class CareGiverAccess(DBContext context)
{
    private readonly DBContext _context = context;
    private readonly DataMapping _dataMapping = new(context);

    public async Task<IResult> LoadAllCareGivers()
    {
        List<Caregiver> caregivers = await _dataMapping.GetCaregiversAsync();

        if (caregivers == null || caregivers.Count == 0)
        {
            return Results.NotFound();
        }

        List<CaregiverDto> result = [];

        foreach (Caregiver caregiver in caregivers)
        {
            CaregiverDto dto = new()
            {
                CaregiverID = caregiver.CaregiverID,
                Name = $"{caregiver.FirstName} {caregiver.LastName}",
                Patients = await _dataMapping.GetPatientsForCaregiverAsync(caregiver)
            };

            result.Add(dto);
        }

        return Results.Ok(result);
    }

    public async Task<IResult> LoadCareGiverById(Guid id)
    {
        List<Caregiver> caregivers = await _dataMapping.GetCaregiversAsync();
        Caregiver? output = caregivers.FirstOrDefault(c => c.CaregiverID == id);

        if (output is null)
        {
            return Results.NotFound();
        }
        CaregiverDto dto = new()
        {
            Name = $"{output.FirstName} {output.LastName}",
            Patients = await _dataMapping.GetPatientsForCaregiverAsync(output)
        };
        return Results.Ok(dto);
    }

    //public IResult LoadCareGiverByName(string? firstName, string? lastName)
    //{
    //    Caregiver? output = _context.Caregivers.AsNoTracking().FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
    //    if (output is null)
    //    {
    //        return Results.NotFound();
    //    }
    //    return Results.Ok(output);
    //}

    public async Task<IResult> CreateCareGiver(Caregiver careGiver)
    {
        if (careGiver is null)
        {
            return Results.BadRequest("Caregiver data is required.");
        }
        careGiver.CaregiverID = Guid.NewGuid();
        _ = _context.Caregivers.Add(careGiver);
        _ = await _context.SaveChangesAsync();
        return Results.Created($"/caregivers/{careGiver.FirstName} {careGiver.LastName}", careGiver);
    }
}
