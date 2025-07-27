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
}
