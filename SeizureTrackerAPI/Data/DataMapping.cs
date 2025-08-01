using Microsoft.EntityFrameworkCore;
using SeizureTrackerAPI.Context;
using SeizureTrackerAPI.DTO;
using SeizureTrackerAPI.Models;

namespace SeizureTrackerAPI.Data;

public class DataMapping(DBContext context)
{
    private readonly DBContext _context = context;

    public async Task<List<Caregiver>> GetCaregiversAsync()
    {
        return await _context.Caregivers
            .Include(c => c.CaregiverLinks!)
            .ThenInclude(link => link.Patient)
            .ThenInclude(p => p.Seizures)
            .ToListAsync();
    }

    public async Task<List<PatientDto>> GetPatientsForCaregiverAsync(Caregiver caregiver)
    {
        return await Task.Run(() => caregiver.CaregiverLinks!
            .Where(link => link.Patient != null)
            .Select(link => MapPatientToDto(link.Patient!))
            .ToList() ?? []);
    }

    private PatientDto MapPatientToDto(Patient patient)
    {
        return new PatientDto
        {
            PatientID = patient.PatientID,
            Name = $"{patient.FirstName} {patient.LastName}",
            DateOfBirth = patient.DateOfBirth,
            Seizures = patient.Seizures?.Select(s => new SeizureDto
            {
                SeizureID = s.SeizureID,
                SeizureDateTime = s.SeizureDateTime,
                SeizureSeverity = s.SeizureSeverity,
                SeizureDurationMinutes = s.SeizureDurationMinutes,
                SeizureComments = s.SeizureComments
            }).ToList() ?? []
        };
    }
}
