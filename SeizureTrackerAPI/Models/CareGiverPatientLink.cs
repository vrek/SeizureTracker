using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class CaregiverPatientLink
{
    [Key]
    public Guid LinkID { get; set; }

    [Required]
    public Guid CaregiverID { get; set; }

    public Caregiver Caregiver { get; set; }

    [Required]
    public Guid PatientID { get; set; }

    public Patient Patient { get; set; }
}
