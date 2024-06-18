

using Microsoft.EntityFrameworkCore;
using SchoolApp.DAL.Entities;

namespace SchoolApp.DAL.Context
{
    public partial class SchoolContext : DbContext
    {
        #region "Constructor"
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        #endregion

        #region "Db Sets"
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        #endregion

    }
}
