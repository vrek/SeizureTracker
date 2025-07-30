using Microsoft.EntityFrameworkCore;
using SeizureTrackerAPI.Context;
using SeizureTrackerAPI.Models;

namespace SeizureTrackerAPI.Data;

public class PatientDataAccess(DBContext context)
{
    private readonly DBContext _context = context;

    public IResult LoadAllPatients()
    {

        List<Patient>? output = [.. _context.Patients.AsNoTracking()];
        if (output is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(output);

    }

    public IResult LoadPatientById(Guid id)
    {
        Patient? output = _context.Patients.AsNoTracking().FirstOrDefault(p => p.PatientID == id);
        if (output is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(output);
    }

    public IResult LoadPatientByName(string? firstName, string? lastName)
    {
        Patient? output = _context.Patients.AsNoTracking().FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
        if (output is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(output);
    }

    public IResult CreatePatient(Patient patient)
    {
        if (patient is null)
        {
            return Results.BadRequest("Patient data is required.");
        }

        patient.PatientID = Guid.NewGuid();
        _ = _context.Patients.Add(patient);
        _ = _context.SaveChanges();
        return Results.Created($"/patients/{patient.PatientID}", patient);
    }
}
