using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.DTO;

public class SeizureDto
{
    public Guid SeizureID { get; set; }
    public DateTime SeizureDateTime { get; set; }
    public int SeizureSeverity { get; set; }
    public int SeizureDurationMinutes { get; set; }

    [MaxLength(5000)]
    public string SeizureComments { get; set; } = string.Empty;
}
