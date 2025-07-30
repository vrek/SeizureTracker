using Microsoft.EntityFrameworkCore;
using SeizureTrackerAPI.Context;
using SeizureTrackerAPI.DTO;
using SeizureTrackerAPI.Models;

namespace SeizureTrackerAPI.Data;

public class CareGiverAccess(DBContext context)
{
    private readonly DBContext _context = context;

    public async Task<IResult> LoadAllCareGivers()
    {
        List<CaregiverDto>? caregivers = await _context.Caregivers
        .Include(c => c.CaregiverLinks!)
        .ThenInclude(link => link.Patient)
        .ThenInclude(p => p.Seizures)
        .Select(static c => new CaregiverDto
        {
            CaregiverID = c.CaregiverID,
            Name = $"{c.FirstName} {c.LastName}",
            Patients = c.CaregiverLinks!
                .Where(link => link.Patient != null)
                .Select(link => new PatientDto
                {
                    PatientID = link.Patient.PatientID,
                    Name = $"{link.Patient.FirstName} {link.Patient.LastName}",
                    DateOfBirth = link.Patient.DateOfBirth,
                    Seizures = link.Patient.Seizures!.Select(s => new SeizureDto
                    {
                        SeizureID = s.SeizureID,
                        SeizureDateTime = s.SeizureDateTime,
                        SeizureSeverity = s.SeizureSeverity,
                        SeizureDurationMinutes = s.SeizureDurationMinutes,
                        SeizureComments = s.SeizureComments
                    }).ToList()
                }
            ).ToList()
        }).ToListAsync();

        return Results.Ok(caregivers);
    }


    public IResult LoadCareGiverById(Guid id)
    {
        Caregiver? output = _context.Caregivers.AsNoTracking().FirstOrDefault(p => p.CaregiverID == id);
        if (output is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(output);
    }

    public IResult LoadCareGiverByName(string? firstName, string? lastName)
    {
        Caregiver? output = _context.Caregivers.AsNoTracking().FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
        if (output is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(output);
    }

    public IResult CreateCareGiver(Caregiver careGiver)
    {
        if (careGiver is null)
        {
            return Results.BadRequest("Caregiver data is required.");
        }
        careGiver.CaregiverID = Guid.NewGuid();
        _ = _context.Caregivers.Add(careGiver);
        _ = _context.SaveChanges();
        return Results.Created($"/caregivers/{careGiver.FirstName} {careGiver.LastName}", careGiver);
    }
}
