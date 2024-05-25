namespace TutorZealand.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int EducationId { get; set; }
        public byte?[] File { get; set; } = [];
    }
}
