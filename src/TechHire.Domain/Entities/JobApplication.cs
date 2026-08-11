namespace TechHire.Domain.Entities;

public class JobApplication : BaseEntity
{
    public required Guid VacancyId { get; set; }
    public required Vacancy Vacancy { get; set; }
    public required Guid CandidateId { get; set; }
    public required CandidateProfile Candidate { get; set; }
    public ApplicationStatus Status { get; set; }
    public string? CoverLetter { get; set; }
    public int MatchScore { get; set; }
}