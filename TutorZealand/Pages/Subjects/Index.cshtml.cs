using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutorZealand.Models;

namespace TutorZealand.Pages.Subjects
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Subjects = _context.Subjects.ToList();
        }
    }
}
