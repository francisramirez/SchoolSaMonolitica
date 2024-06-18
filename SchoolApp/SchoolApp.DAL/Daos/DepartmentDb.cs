
using SchoolApp.DAL.Context;
using SchoolApp.DAL.Interfaces;
using SchoolApp.DAL.Models;

namespace SchoolApp.DAL.Daos
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
            DepartmentModel model = new DepartmentModel();

            var department = this.context.Departaments.Find(departmentId);

            return model;
        }

        public List<DepartmentModel> GetDepartments()
        {
            return this.context.Departaments.Where(depto => !depto.Deleted)
                                .Select(depto => new DepartmentModel()
                                {
                                    Administrator = depto.Administrator,
                                    Budget = depto.Budget,
                                    CreateUser = depto.CreationUser,
                                    CreationDate = depto.CreationDate,
                                    DepartmentId = depto.DepartmentId,
                                    Name = depto.Name,
                                    StartDate = depto.StartDate

                                }).ToList();
        }

        public void RemoveDepartment(DepartmentRemoveModel departmentRemove)
        {
            //      if (departmentRemove is not null)
            //   {
            //          throw new ArgumentNullException("El objeto no puede ser nulo.");
            //}

            //      if (departmentRemove != null)
            //      {

            //      }

            ArgumentNullException.ThrowIfNull(departmentRemove, "El objeto no puede ser nulo.");


            throw new NotImplementedException();
        }

        public void SaveDepartment(DepartmentAddModel departmentAdd)
        {
            ArgumentNullException.ThrowIfNull(departmentAdd, "El objeto no puede ser nulo.");
           
        }

        public void UpdateDepartment(DepartmentUpdateModel departmentUpdate)
        {
            ArgumentNullException.ThrowIfNull(departmentUpdate, "El objeto no puede ser nulo.");

            throw new NotImplementedException();
        }
    }
}
