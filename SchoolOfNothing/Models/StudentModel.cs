using System.ComponentModel;

namespace SchoolOfNothing.Models
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Date of birth")]
        public DateTime BirthDate { get; set; }
    }
}
