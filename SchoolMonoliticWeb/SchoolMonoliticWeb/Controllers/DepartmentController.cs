using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMonoliticWeb.BL.Interfaces;
using SchoolMonoliticWeb.Data.Context;
using SchoolMonoliticWeb.Data.Interfaces;
using SchoolMonoliticWeb.Data.Models;

namespace SchoolMonoliticWeb.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentDb departmentService;

        public DepartmentController(IDepartmentDb departmentDb)
        {

            this.departmentService = departmentDb;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            var departments = this.departmentService.GetDepartments();
            return View(departments);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            var depto = this.departmentService.GetDepartment(id);

            return View(depto);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentAddModel departmentAdd)
        {
            try
            {
                departmentAdd.CreationDate = DateTime.Now;
                departmentAdd.CreationUser = 1;
                this.departmentService.SaveDepartment(departmentAdd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            var depto = this.departmentService.GetDepartment(id);

            return View(depto);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentUpdateModel updateModel)
        {
            try
            {
                this.departmentService.UpdateDepartment(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
