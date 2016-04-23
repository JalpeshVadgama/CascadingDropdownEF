using System.ComponentModel.DataAnnotations.Schema;

namespace CascadingDropdownEF.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StandardId { get; set; }
        [ForeignKey("StandardId")]
        public Standard Standard { get; set; }
    }
}