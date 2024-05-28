using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TutorZealand.Models;

namespace TutorZealand.Pages.Sessions
{
    public class BookDetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public SessionDto Session { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        public BookDetailsModel(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult OnPost()
        {

            var student = _context.Students.FirstOrDefault(x => x.Email == Student.Email);

            if (student == null)
            {
                var newStudent = new Student()
                {
                    Email = Student.Email,
                };

                _context.Add(newStudent);
                _context.SaveChanges();
                student = newStudent;
            }

            var newBooking = new Booking
            {
                SessionId = Session.Id,
                StudentId = student.Id
            };

            _context.Add(newBooking);
            
            _context.SaveChanges();

            return RedirectToPage("/Sessions/Index"); // Redirect to a confirmation page
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = _context.Sessions
                .FirstOrDefault(m => m.Id == id);

            var teacher = _context.AssistantTeachers.FirstOrDefault(x => x.Id == session.AssistantTeacherId);

            Session = new SessionDto()
            {
                Id = session.Id,
                StartDate = session.StartDate,
                EndDate = session.EndDate,
                Teacher = teacher,
            };

            if (Session == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
