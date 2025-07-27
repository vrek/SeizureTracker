using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class Patient
{
    [Key]
    public Guid PatientID { get; set; }
    [MaxLength(50)]
    public required string FirstName { get; set; }
    [MaxLength(50)]
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    //Navigation Properties
    public List<Seizures>? Seizures { get; set; }

}
