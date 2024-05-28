
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
        }
    }
}
