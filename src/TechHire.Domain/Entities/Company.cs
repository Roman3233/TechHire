namespace TechHire.Domain.Entities;

public class Company : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required Guid RecruiterUserId { get; set; }
    public required User RecruiterUser { get; set; }
}