namespace SeizureTrackerUI.Models;

public class CareGiverModel
{
    public Guid CareGiverID { get; set; }
    public required string FirstName { get; set; } = string.Empty;
    public required string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public required string Email { get; set; }
    //public List<Patient>? Patients { get; set; }

}
