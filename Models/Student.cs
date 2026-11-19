namespace SportsUp.Models
{
    public class Student
    {
        //Student information
        public int Id { get; set; }
        public string StudentId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string House { get; set; } = string.Empty;

    }
}
