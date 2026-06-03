using System.Data.Entity;

namespace CodeFirstApp
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDB")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
