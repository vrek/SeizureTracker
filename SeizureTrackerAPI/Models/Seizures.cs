using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class Seizure
{
    [Key]
    public Guid SeizureID { get; set; }

    public DateTime SeizureDateTime { get; set; }

    public int SeizureSeverity { get; set; }

    public int SeizureDurationMinutes { get; set; }

    [MaxLength(5000)]
    public string SeizureComments { get; set; }

    // Foreign key to Patient
    public Guid PatientID { get; set; }

    public Patient Patient { get; set; }
}
