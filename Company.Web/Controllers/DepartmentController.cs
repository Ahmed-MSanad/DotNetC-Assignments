using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Service.Interfaces.IDepartment;
using Company.Service.Services.DepartmentService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var departments = _departmentService.GetAll();
            return View(departments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentDto department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _departmentService.Add(department);
                    //return RedirectToAction("Index");
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("DepartmentError", "Validation Error");
                return View(department);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(department);
            }
        }
        [HttpGet]
        public IActionResult Details(int? id, string viewName = "Details")
        {
            //Console.WriteLine($"The id is {id}"); // For Debugging
            var department = _departmentService.GetById(id);
            if(department is null)
            {
                return RedirectToAction("NotFoundPage", "Home");
            }
            return View(viewName, department);
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            return Details(id, "Update");
        }
        [HttpPost]
        public IActionResult Update(int? id, DepartmentDto department)
        {
            if(id != department.Id)
            {
                return RedirectToAction("NotFoundPage", "Home");
            }

            _departmentService.Update(department);
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var department = _departmentService.GetById(id);
            if(department is null)
            {
                return RedirectToAction("NotFoundPage", "Home");
            }
            _departmentService.Delete(department);
            return RedirectToAction("Index");
        }
    }
}
