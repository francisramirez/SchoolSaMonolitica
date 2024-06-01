using SchoolMonoliticWeb.Data.Models;

namespace SchoolMonoliticWeb.Data.Interfaces
{
    public interface IDepartmentDb
    {
        List<DepartmentModel> GetDepartments();
        DepartmentModel GetDepartment(int departmentId);
        void SaveDepartment(DepartmentAddModel departmentAdd);
        void UpdateDepartment(DepartmentUpdateModel departmentAdd);
        void RemoveDepartment(DepartmentRemoveModel departmentAdd);

    }
}