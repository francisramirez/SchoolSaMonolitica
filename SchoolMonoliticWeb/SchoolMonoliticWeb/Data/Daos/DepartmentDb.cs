using SchoolMonoliticWeb.Data.Context;
using SchoolMonoliticWeb.Data.Entities;
using SchoolMonoliticWeb.Data.Exceptions;
using SchoolMonoliticWeb.Data.Interfaces;
using SchoolMonoliticWeb.Data.Models;

namespace SchoolMonoliticWeb.Data.Daos
{
    public class DepartmentDb : IDepartmentDb
    {
        private readonly SchoolContext context;

        public DepartmentDb(SchoolContext context)
        {
            this.context = context;
        }

        public DepartmentModel GetDepartment(int departmentId)
        {

            var department = this.context.Departments.Find(departmentId);

            if (department is null)
            {
                throw new DepartmentDbException("Este departamento no se encuentra registrado.");

            }

            DepartmentModel departmentModel = new DepartmentModel()
            {
                Administrator = department.Administrator,
                Budget = department.Budget,
                CreateUser = department.CreationUser,
                CreationDate = department.CreationDate,
                Name = department.Name,
                StartDate = department.StartDate,
                DepartmentId = department.DepartmentId
            };

            return departmentModel;
        }

        public List<DepartmentModel> GetDepartments()
        {
            return this.context.Departments.Select(cd => new DepartmentModel()
            {
                Administrator = cd.Administrator,
                Budget = cd.Budget,
                CreateUser = cd.CreationUser,
                CreationDate = cd.CreationDate,
                DepartmentId = cd.DepartmentId,
                Name = cd.Name,
                StartDate = cd.StartDate
            }).ToList();
        }

        public void RemoveDepartment(DepartmentRemoveModel removeModel)
        {
            var departmentToRemove = this.context.Departments.Find(removeModel.DepartmentId);

            if (departmentToRemove is null)
            {
                throw new DepartmentDbException("Este departamento no se encuentra registrado.");

            }

            departmentToRemove.Deleted = removeModel.Deleted;
            departmentToRemove.DeletedDate = removeModel.DeleteDate;
            departmentToRemove.UserDeleted = removeModel.UserDelete;

            this.context.Departments.Remove(departmentToRemove);
            this.context.SaveChanges();
        }

        public void SaveDepartment(DepartmentAddModel departmentAdd)
        {
            Department department = new Department()
            {
                Administrator = departmentAdd.Administrator,
                Budget = departmentAdd.Budget,
                CreationDate = departmentAdd.CreationDate,
                CreationUser = departmentAdd.CreationUser,
                Name = departmentAdd.Name,
                StartDate = departmentAdd.StartDate
            };

            this.context.Departments.Add(department);
            this.context.SaveChanges();
        }

        public void UpdateDepartment(DepartmentUpdateModel departmentUpdate)
        {
            var departmentToUpdate = this.context.Departments.Find(departmentUpdate.DepartmentId);

            if (departmentToUpdate is null)
            {
                throw new DepartmentDbException("Este departamento no se encuentra registrado.");

            }


        }
    }
}
