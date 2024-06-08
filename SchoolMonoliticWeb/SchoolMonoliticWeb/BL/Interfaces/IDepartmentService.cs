using SchoolMonoliticWeb.Data.Models;

namespace SchoolMonoliticWeb.BL.Interfaces
{
    public interface IDepartmentService
    {
        List<DepartmentModel> GetDepartments();
    }
}
