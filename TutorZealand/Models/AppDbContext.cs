
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
    }
}
