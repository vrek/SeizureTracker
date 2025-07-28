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
}
