using SeizureTrackerAPI.Models;
using System.Text.Json;

namespace SeizureTrackerAPI.Data;

public class PatientData
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    public List<Patient> Patients { get; private set; } = [];
    public PatientData()
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "PatientData.json");

        string json = File.ReadAllText(filePath);

        Patients = JsonSerializer.Deserialize<List<Patient>>(json, _options) ?? [];
    }
    public void WritePatientData()
    {
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "PatientData.json");
            string json = JsonSerializer.Serialize(Patients, _options);
            File.WriteAllText(filePath, json);
            ReloadPatientData();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing PatientData.json: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
    public void ReloadPatientData()
    {
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "PatientData.json");
            string json = File.ReadAllText(filePath);
            List<CareGiver>? loaded = JsonSerializer.Deserialize<List<CareGiver>>(json, _options);
            if (loaded is not null)
            {
                Patients.Clear();
                Patients.AddRange(loaded);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reloading PatientData.json: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
}
