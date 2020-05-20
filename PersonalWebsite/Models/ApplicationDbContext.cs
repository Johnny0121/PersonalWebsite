using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Entities;
using PersonalWebsite.Entities.Academics;
using PersonalWebsite.Entities.WorkExperience;

namespace PersonalWebsite.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<WorkExperienceEntity> WorkExperiences { get; set; }
        public DbSet<AcademicExperienceEntity> AcademicExperiences { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<SocialMediaEntity> SocialMedias { get; set; }
    }
}
