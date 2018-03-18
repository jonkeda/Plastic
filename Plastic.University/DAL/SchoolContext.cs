using ContosoUniversity.Models;
using System.CodeDom.Compiler;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Dal
{
    [GeneratedCode("","")]
    public partial class SchoolContext : DbContext
    {
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Enrollment> Enrollments{ get; set; }
        public DbSet<Instructor> Instructors{ get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments{ get; set; }
        public DbSet<Person> People{ get; set; }
        public DbSet<Student> Students{ get; set; }
    }
}
