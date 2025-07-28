using SeizureTrackerAPI.Data;

namespace SeizureTrackerAPI.Endpoints;

public static class PatientEndpoints
{
    public static void AddPatientEndpoints(this WebApplication app)
    {
        _ = app.MapGet("/patients", LoadAllPatients);
        _ = app.MapGet("/patients/{id}", LoadPatientById);
        _ = app.MapGet("/patients/{firstname}/{lastname}", LoadPatientByName);
        _ = app.MapPost("/patients/create", Createpatient);
    }

    private static IResult LoadAllPatients(PatientData data)
    {
        return Results.Ok(data.Patients);
    }

    private static IResult LoadPatientById(
        PatientData data,
        Guid id)
    {
        Models.Patient? output = data.Patients.FirstOrDefault(c => c.PatientID == id);

        if (output is null)
        {
            return Results.NotFound();
        }

        return Results.Ok(output);
    }

    private static IResult LoadPatientByName(
        PatientData data,
        string? firstname,
        string? lastname)
    {
        Models.Patient? output = data.Patients.FirstOrDefault(c => c.FirstName == firstname && c.LastName == lastname);

        if (output is null)
        {
            return Results.NotFound();
        }

        return Results.Ok(output);
    }

    private static IResult Createpatient(
        PatientData data,
        Models.Patient patient)
    {
        if (patient is null)
        {
            return Results.BadRequest("patient data is required.");
        }
        patient.PatientID = Guid.NewGuid();
        data.Patients.Add(patient);
        data.WritePatientData();
        return Results.Created($"/patients/{patient.PatientID}", patient);
    }
}
