namespace SeizureTrackerUI.Models;
public class PatientModel
{

    public Guid PatientID { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    //Navigation Properties
    //public List<Seizures>? Seizures { get; set; }

}