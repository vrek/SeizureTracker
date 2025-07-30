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

    private static IResult LoadAllPatients(PatientDataAccess data)
    {
        return data.LoadAllPatients();
    }

    private static IResult LoadPatientById(
        PatientDataAccess data,
        Guid id)
    {
        return data.LoadPatientById(id);
    }

    private static IResult LoadPatientByName(
        PatientDataAccess data,
        string? firstname,
        string? lastname)
    {
        return data.LoadPatientByName(firstname, lastname);
    }

    private static IResult Createpatient(
        PatientDataAccess data,
        Models.Patient patient)
    {
        return data.CreatePatient(patient);
    }
}
