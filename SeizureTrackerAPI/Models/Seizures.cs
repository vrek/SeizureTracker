using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class Seizures
{
    [Key]
    public Guid SeizureEventId { get; set; }

    public required DateTime SeizureDateTime { get; set; }
    public required int SeizureSeverity { get; set; }
    public required float SeizureDurationMinutes { get; set; }
    [MaxLength(5000)]
    public string? SeizureComments { get; set; }

    //Navigations Properties
    public required Guid Patient { get; set; }

}
