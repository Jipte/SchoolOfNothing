using System.ComponentModel;

namespace SchoolOfNothing.Models
{
    public class ClassroomModel
    {
        public Guid Id { get; set; }
        [DisplayName("Number")]
        public string Number { get; set; }
    }
}
