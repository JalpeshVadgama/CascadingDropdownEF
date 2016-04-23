using System.Collections.Generic;

namespace CascadingDropdownEF.Models
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string Name { get; set; }

        public virtual  ICollection<Student> Students { get; set; }
    }
}