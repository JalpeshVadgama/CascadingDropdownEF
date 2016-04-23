using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CascadingDropdownEF.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnectionString")
        {
            
        }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}