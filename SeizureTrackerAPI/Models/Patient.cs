using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class Patient
{
    [Key]
    public Guid PatientID { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    // Navigation property for seizure tracking
    public ICollection<Seizure>? Seizures { get; set; }

    public ICollection<CaregiverPatientLink>? PatientLinks { get; set; }
}
