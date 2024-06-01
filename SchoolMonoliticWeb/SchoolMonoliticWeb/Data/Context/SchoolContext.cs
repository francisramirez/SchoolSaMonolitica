using Microsoft.EntityFrameworkCore;
using SchoolMonoliticWeb.Data.Entities;

namespace SchoolMonoliticWeb.Data.Context
{
    public class SchoolContext : DbContext
    {
        #region "Constructor"
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        #endregion

        #region "DbSet's"
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion
    }
}
