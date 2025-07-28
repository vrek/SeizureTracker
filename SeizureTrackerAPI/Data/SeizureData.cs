using SeizureTrackerAPI.Models;
using System.Text.Json;

namespace SeizureTrackerAPI.Data;

public class SeizureData
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    public List<Seizures> seizures { get; private set; } = [];
    public SeizureData()
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "SeizureData.json");

        string json = File.ReadAllText(filePath);

        seizures = JsonSerializer.Deserialize<List<Seizures>>(json, _options) ?? [];
    }
    public void WriteSeizureData()
    {
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "PatientData.json");
            string json = JsonSerializer.Serialize(seizures, _options);
            File.WriteAllText(filePath, json);
            ReloadSeizureData();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing SeizureData.json: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
    public void ReloadSeizureData()
    {
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "PatientData.json");
            string json = File.ReadAllText(filePath);
            List<Seizures>? loaded = JsonSerializer.Deserialize<List<Seizures>>(json, _options);
            if (loaded is not null)
            {
                seizures.Clear();
                seizures.AddRange(loaded);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reloading SeizureData.json: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
}
