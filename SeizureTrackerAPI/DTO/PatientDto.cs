namespace SeizureTrackerAPI.DTO;

public class PatientDto
{
    public Guid PatientID { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }

    public List<SeizureDto> Seizures { get; set; } = [];
}
