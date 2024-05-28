using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutorZealand.Models;

namespace TutorZealand.Pages.Subjects
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public List<Subject> Subjects { get; set; }
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            //var subject = new Subject() { Id = 1,Name = "datamatiker", Description = "ndjalc kasjd c"};
            //_context.Subjects.Add(subject);
            //_context.SaveChanges();

            //Subjects = _context.Subjects.ToList();

            //Console.WriteLine("Count Of Subjects" + _context.Subjects.ToList().Count);
        }
    }
}
