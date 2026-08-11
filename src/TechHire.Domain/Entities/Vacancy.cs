namespace TechHire.Domain.Entities;

public class Vacancy : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required Guid CompanyId { get; set; }
    public required Company Company { get; set; }
    public List<Skill> RequiredSkills { get; set; } = [];
}