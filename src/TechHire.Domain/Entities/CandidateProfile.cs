namespace TechHire.Domain.Entities;

public class CandidateProfile : BaseEntity
{
    public required string FullName { get; set; }
    public string? Bio { get; set; }
    public string? Experience { get; set; }
    public string? Education { get; set; }
    public required Guid UserId { get; set; }
    public required User User { get; set; }
    public List<Skill> Skills { get; set; } = [];
}