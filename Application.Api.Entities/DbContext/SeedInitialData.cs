using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Entities.DbContext
{
    public static class SeedInitialData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                 new City { CityId = 1, Name = "Nanded", IsActive = true, CreatedDate = DateTime.Now, CreatedBy = 1, LastModifiedDate = DateTime.Now, LastModifiedBy = 1}
            );

            modelBuilder.Entity<Country>().HasData(
                 new Country { CountryId = 1, Name = "India", IsActive = true, CreatedDate = DateTime.Now, CreatedBy = 1, LastModifiedDate = DateTime.Now, LastModifiedBy = 1 }
            );

            modelBuilder.Entity<Branch>().HasData(
                new Branch { BranchId = 1, Name = "Civil Engineering", Description="", IsActive = true, CreatedDate = DateTime.Now, CreatedBy = 1, LastModifiedDate = DateTime.Now, LastModifiedBy = 1 }
            );

            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectId = 1, Name = "Engineering Mechanics", Description = "", BranchId = 1, IsActive = true, CreatedDate = DateTime.Now, CreatedBy = 1, LastModifiedDate = DateTime.Now, LastModifiedBy = 1 }
            );

            modelBuilder.Entity<Chapter>().HasData(
                new Chapter { ChapterId = 1, Order = 1, Title = "Chapter-1", Content = "", SubjectId = 1, IsActive = true, CreatedDate = DateTime.Now, CreatedBy = 1, LastModifiedDate = DateTime.Now, LastModifiedBy = 1 }
            );

            modelBuilder.Entity<Lesson>().HasData(
                new Lesson { LessonId = 1, Title = "Lesson-1", Description = "Lesson on Mechanics", LessonType = LessonType.Video, ChapterId = 1, IsActive = true, CreatedDate = DateTime.Now, CreatedBy = 1, LastModifiedDate = DateTime.Now, LastModifiedBy = 1 }
            );
        }
    }
}
