using Microsoft.EntityFrameworkCore;
using TechHire.Domain.Entities;

namespace TechHire.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; } = default!;
    public DbSet<CandidateProfile> CandidateProfiles { get; set; } = default!;
    public DbSet<Vacancy> Vacancies { get; set; } = default!;
    public DbSet<JobApplication> JobApplications { get; set; } = default!;
    public DbSet<Company> Companies { get; set; } = default!;
    public DbSet<Skill> Skills { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Skill>().HasKey(s => s.Name);

        modelBuilder.Entity<CandidateProfile>()
            .HasMany(c => c.Skills)
            .WithMany(); 

        modelBuilder.Entity<Vacancy>()
            .HasMany(v => v.RequiredSkills)
            .WithMany();
    }
}