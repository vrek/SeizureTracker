using System.ComponentModel.DataAnnotations;

namespace SeizureTrackerAPI.Models;

public class CareGiver
{
    [Key]
    public Guid CareGiverID { get; set; }
    [MaxLength(50)]
    public required string FirstName { get; set; } = string.Empty;
    [MaxLength(50)]
    public required string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    [Required]
    [MaxLength(100)]
    public required string Email { get; set; }

    public List<Guid>? Patients { get; set; }

}