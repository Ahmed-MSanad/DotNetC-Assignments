using Company.Data.Models;
using Company.Service.Interfaces.IDepartment;
using Company.Service.Interfaces.IEmployee;
using Company.Service.Services.EmployeeService.Dto;
using Microsoft.AspNetCore.Mvc;


namespace Company.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }
        //[HttpGet] => casue a problem -> prevents the searched data to be returned and displayed.
        public IActionResult Index(string searchInp) // search for an employee by Name
        {
            IEnumerable<EmployeeDto> employees = new List<EmployeeDto>();

            if (string.IsNullOrEmpty(searchInp)) // if search string is null or empty then get all employees
                employees = _employeeService.GetAll();
            else
                employees = _employeeService.GetEmployeeByName(searchInp);
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeDto employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);
                    return RedirectToAction(nameof(Index));
                }
                return View(employee);

            }
            catch(Exception ex)
            {
                return View(employee);
            }
        }
    }
}
