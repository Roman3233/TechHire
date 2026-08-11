using TechHire.Domain.Enums;

namespace TechHire.Domain.Entities;

public class User : BaseEntity
{
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string Name { get; set; }
    public required UserRole Role { get; set; }
}