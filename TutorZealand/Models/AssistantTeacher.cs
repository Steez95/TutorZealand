namespace TutorZealand.Models
{
    public class AssistantTeacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int EducationId { get; set; }
        public string Description { get; set; }
    }
}
