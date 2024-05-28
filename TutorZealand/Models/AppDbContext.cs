
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TutorZealand.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }

        public DbSet<AssistantTeacher> AssistantTeachers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Introduction to Programming", Description = "Learn the basics of programming using Python." },
                new Subject { Id = 2, Name = "Object-Oriented Programming", Description = "Understand the principles of OOP and how to apply them in C#." },
                new Subject { Id = 3, Name = "Web Development", Description = "Build dynamic websites and web applications using HTML, CSS, and JavaScript." },
                new Subject { Id = 4, Name = "Data Structures and Algorithms", Description = "Study fundamental data structures and algorithms in Java." },
                new Subject { Id = 5, Name = "Database Management Systems", Description = "Learn about relational databases and SQL." },
                new Subject { Id = 6, Name = "Mobile App Development", Description = "Create mobile applications for Android and iOS using Flutter." },
                new Subject { Id = 7, Name = "Software Engineering", Description = "Explore the software development lifecycle and best practices." },
                new Subject { Id = 8, Name = "Machine Learning", Description = "Introduction to machine learning concepts and applications using Python." },
                new Subject { Id = 9, Name = "Cloud Computing", Description = "Understand cloud services and how to deploy applications to the cloud." },
                new Subject { Id = 10, Name = "Cybersecurity", Description = "Learn about securing systems, networks, and data from cyber threats." }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "Roskilde Campus" },
                new Location { Id = 2, Name = "Næstved Campus" },
                new Location { Id = 3, Name = "København Campus" }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, Name = "1A", LocationId = 1 },
                new Room { Id = 2, Name = "2A", LocationId = 1 },
                new Room { Id = 3, Name = "3A", LocationId = 1 },

                new Room { Id = 4, Name = "1B", LocationId = 2 },
                new Room { Id = 5, Name = "2B", LocationId = 2 },
                new Room { Id = 6, Name = "3B", LocationId = 2 },

                new Room { Id = 7, Name = "1C", LocationId = 3 },
                new Room { Id = 8, Name = "2C", LocationId = 3 },
                new Room { Id = 9, Name = "3C", LocationId = 3 }
            );

            modelBuilder.Entity<Education>().HasData(
                new Education { Id = 1, Name = "Datamatiker" },
                new Education { Id = 2, Name = "Multimedie designer" },
                new Education { Id = 3, Name = "Finansøkonom" }
            );

            modelBuilder.Entity<AssistantTeacher>().HasData(
                 new AssistantTeacher { Id = 1, Name = "Ole Jensen", Email = "ole@zealand.dk", Telephone = "22331122", Description = "Jeg hedder ole", EducationId = 1 },
                 new AssistantTeacher { Id = 2, Name = "Frank Frankfurter", Email = "frank@zealand.dk", Telephone = "33551122", Description = "Jeg hedder Frank og elsker frankurt", EducationId = 1 }
             );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Mert Gultekin", Email = "mert@zealand.dk", EducationId = 1 },
                new Student { Id = 2, Name = "Milad Muladsen", Email = "milad@zealand.dk", EducationId = 1 },
                new Student { Id = 3, Name = "Vagn Ravn", Email = "vang@zealand.dk", EducationId = 1 },
                new Student { Id = 4, Name = "Hulle Tullesen", Email = "hulle@zealand.dk", EducationId = 1 },
                new Student { Id = 5, Name = "Jared Padelecki", Email = "jared@zealand.dk", EducationId = 1 },
                new Student { Id = 6, Name = "Jensen Ackles", Email = "jensen@zealand.dk", EducationId = 1 }
            );

            modelBuilder.Entity<Session>().HasData(
                new Session 
                { 
                    Id = 1, 
                    SubjectId = 1, 
                    EducationId = 1, 
                    AssistantTeacherId = 1, 
                    LocationId = 1, 
                    RoomId = 1, 
                    StartDate = DateTime.Now.AddDays(1), 
                    EndDate = DateTime.Now.AddDays(1).AddHours(1),
                    IsActive = true,
                    Description = "Vi skal lære om basale programmerings ting sammen med mig, Ole Jensen."
                }
            );

            modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 1, SessionId = 1, StudentId = 1 },
                new Booking { Id = 2, SessionId = 1, StudentId = 2 },
                new Booking { Id = 3, SessionId = 1, StudentId = 3 },
                new Booking { Id = 4, SessionId = 1, StudentId = 4 },
                new Booking { Id = 5, SessionId = 1, StudentId = 5 },
                new Booking { Id = 6, SessionId = 1, StudentId = 6 }
            );

            modelBuilder.Entity<Application>().HasData(
                new Application { Id = 1, StudentId = 1, EducationId = 1, File = [0,2,3,45,5,1,2] }
            );

        }
    }
}
