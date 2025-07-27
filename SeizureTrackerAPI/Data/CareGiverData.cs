using SeizureTrackerAPI.Models;
using System.Text.Json;

namespace SeizureTrackerAPI.Data;

public class CareGiverData
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    public List<CareGiver> CareGivers { get; private set; }
    public CareGiverData()
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "CareGiverData.json");

        string json = File.ReadAllText(filePath);

        CareGivers = JsonSerializer.Deserialize<List<CareGiver>>(json, _options) ?? [];
    }
    public void WriteCareGiverData()
    {
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "CareGiverData.json");
            string json = JsonSerializer.Serialize(CareGivers, _options);
            File.WriteAllText(filePath, json);
            ReloadCareGiverData();
        }
        catch (Exception ex)
        {
            // For demonstration, write to the console. Replace with your preferred logging.
            Console.WriteLine($"Error writing CareGiverData.json: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
            // Optionally, rethrow or handle as needed.
        }
    }
    public void ReloadCareGiverData()
    {
        try
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "CareGiverData.json");
            string json = File.ReadAllText(filePath);
            List<CareGiver>? loaded = JsonSerializer.Deserialize<List<CareGiver>>(json, _options);
            if (loaded is not null)
            {
                CareGivers.Clear();
                CareGivers.AddRange(loaded);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reloading CareGiverData.json: {ex.Message}");
        }
    }
}
