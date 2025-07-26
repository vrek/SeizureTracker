using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class Seizures
{
    [Key]
    public Guid SeizureEventId { get; set; }

    public required DateTime SeizureDateTime { get; set; }
    public required int SeizureSeverity { get; set; }
    public required float SeizueDurationMinutes { get; set; }
    [MaxLength(5000)]
    public string? SeizureComments { get; set; }

    //Navigations Properties
    public required Patient Patient { get; set; }

}
