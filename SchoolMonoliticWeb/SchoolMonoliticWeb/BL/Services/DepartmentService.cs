using SchoolMonoliticWeb.BL.Interfaces;
using SchoolMonoliticWeb.Data.Interfaces;
using SchoolMonoliticWeb.Data.Models;

namespace SchoolMonoliticWeb.BL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentDb departmentDb;

        public DepartmentService(IDepartmentDb departmentDb)
        {
            this.departmentDb = departmentDb;
        }
        public List<DepartmentModel> GetDepartments()
        {
            return this.departmentDb.GetDepartments();
        }
    }
}
