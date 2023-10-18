using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace StudentManager.Models
{
    public class StudentManagerDbContext : DbContext
    {
        public StudentManagerDbContext(DbContextOptions<StudentManagerDbContext> options):base(options)
        {
                
        }
        public StudentManagerDbContext()
        {
                
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
            .HasOne(s => s.Class)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.ClassId);

            modelBuilder.Entity<Student>()
            .HasOne(s => s.Gender)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.GenderId);


            modelBuilder.Entity<Gender>()
                .HasData(
                  new Gender
                  {
                      Id = 1,
                      Name = "Male"
                  },
                  new Gender
                  {
                      Id = 2,
                      Name = "Female"
                  },
                  new Gender
                  {
                      Id = 3,
                      Name = "Others"
                  }
                );
            modelBuilder.Entity<Class>()
                .HasData(
                    new Class
                    {
                        Id=1,
                        Name="One",
                        CreatedDate= DateTime.Today
                    },
                    new Class
                    {
                        Id = 2,
                        Name = "Two",
                        CreatedDate = DateTime.Today
                    },
                    new Class
                    {
                        Id = 3,
                        Name = "Three",
                        CreatedDate = DateTime.Today
                    },
                    new Class
                    {
                        Id = 4,
                        Name = "Four",
                        CreatedDate = DateTime.Today
                    },
                    new Class
                    {
                        Id = 5,
                        Name = "Five",
                        CreatedDate = DateTime.Today
                    },
                    new Class
                    {
                        Id = 6,
                        Name = "Six",
                        CreatedDate = DateTime.Today
                    }

                );
            modelBuilder.Entity<Student>()
                .HasData(
                    new Student
                    {
                        Id=Guid.NewGuid(),
                        Name="Shuvo Islam",
                        DOB= DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate=DateTime.Today,
                        ClassId=1,
                        GenderId=1
                     },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId=3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId =3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId= 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shuvo Islam",
                        DOB = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 1,
                        GenderId = 1
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shawon Sheikh",
                        DOB = DateTime.ParseExact("21/06/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sahabuddin Sheikh",
                        DOB = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 3,
                        GenderId = 3
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Shaiful Sheikh",
                        DOB = DateTime.ParseExact("11/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        CreatedDate = DateTime.Today,
                        ClassId = 2,
                        GenderId = 2
                    }
                );

        }
    }
}
