using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class Caregiver
{
    [Key]
    public Guid CaregiverID { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public DateTime DateOfBirth { get; set; }

    // Nullable foreign key pointing to a Patient (optional association)
    public Guid? PatientID { get; set; }

    public Patient? Patient { get; set; }

    public ICollection<CaregiverPatientLink>? CaregiverLinks { get; set; }
}