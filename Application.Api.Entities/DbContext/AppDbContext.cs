using Application.Api.Entities.Mapping;
using Application.Api.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Entities.DbContext
{
    public class AppDbContext :IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Seed();
            builder.ApplyConfigurationsFromAssembly(typeof(AnnouncementConfiguration).Assembly);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Announcement> Announcement { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<LessonProgress> LessonProgress { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<QuizResult> QuizResult { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
    }
}
