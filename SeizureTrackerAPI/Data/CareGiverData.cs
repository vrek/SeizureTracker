using SeizureTrackerAPI.Models;
using System.Text.Json;

namespace SeizureTrackerAPI.Data;

public class CareGiverData
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    public List<CareGiver> CareGivers { get; private set; } = [];
    public CareGiverData()
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "CareGiverData.json");

        string json = File.ReadAllText(filePath);

        CareGivers = JsonSerializer.Deserialize<List<CareGiver>>(json, _options) ?? [];
    }
}
