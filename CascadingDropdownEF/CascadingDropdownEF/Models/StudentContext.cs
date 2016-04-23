using System.Data.Entity;

namespace CascadingDropdownEF.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnectionString")
        {
            
        }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}