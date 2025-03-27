using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Models;
using Company.Service.Services.EmployeeService.Dto;

namespace Company.Service.Services.DepartmentService.Dto
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        ICollection<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; }
    }
}
