namespace SeizureTrackerAPI.DTO;

public class CaregiverDto
{
    public Guid CaregiverID { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<PatientDto> Patients { get; set; } = [];
}
