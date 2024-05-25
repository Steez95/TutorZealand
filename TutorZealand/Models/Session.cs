namespace TutorZealand.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AssistantTeacherId { get; set; }
        public int SubjectId { get; set; }
        public int RoomId { get; set; }
        public int LocationId { get; set; }
        public bool IsActive { get; set; }
        public int EducationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
