using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Models;
using Company.Service.Services.DepartmentService.Dto;
using Microsoft.AspNetCore.Http;

namespace Company.Service.Services.EmployeeService.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HiringDate { get; set; }
        public IFormFile Image { get; set; }
        public string? ImageUrl { get; set; } // it has to be nullable 
        public DepartmentDto? Department { get; set; } // it has to be nullable 
        public int? departmentId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
