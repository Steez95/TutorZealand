using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutorZealand.Models;

namespace TutorZealand.Pages.Sessions
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public List<SessionDto> Sessions { get; set; } = new List<SessionDto>();
        public IndexModel(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void OnGet()
        {
            var sessions = _context.Sessions.ToList();
            var teachers = _context.AssistantTeachers.ToList();
            var subjects = _context.Subjects.ToList();
            var rooms = _context.Rooms.ToList();
            var locations = _context.Locations.ToList();
            var educations = _context.Educations.ToList();
            var bookings = _context.Bookings.ToList();

            foreach (var session in sessions)
            {
                var newSession = new SessionDto
                {
                    Id = session.Id,
                    Description = session.Description,
                    Education = educations.FirstOrDefault(x => x.Id == session.EducationId),
                    EndDate = session.EndDate,
                    IsActive = session.IsActive,
                    Location = locations.FirstOrDefault(x => x.Id == session.LocationId),
                    Room = rooms.FirstOrDefault(x => x.Id == session.RoomId),
                    StartDate = session.StartDate,
                    Subject = subjects.FirstOrDefault(x => x.Id == session.SubjectId),
                    Teacher = teachers.FirstOrDefault(x => x.Id == session.AssistantTeacherId),
                    Bookings = bookings.Where(x => x.SessionId == session.Id).ToList(),
                };

                Sessions.Add(newSession);
            }
        }
    }

    public class SessionDto
    {
        public int Id { get; set; }
        public Subject? Subject { get; set; }
        public AssistantTeacher? Teacher { get; set; }
        public Location? Location { get; set; }
        public Room? Room { get; set; }
        public Education? Education { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
