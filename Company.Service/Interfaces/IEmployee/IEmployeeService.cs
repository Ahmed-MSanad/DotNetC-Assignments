using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Models;
using Company.Service.Services.EmployeeService.Dto;

namespace Company.Service.Interfaces.IEmployee
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetEmployeeByName(string name);
        IEnumerable<EmployeeDto> GetEmployeesByAddress(string address);
        EmployeeDto GetById(int? id);
        IEnumerable<EmployeeDto> GetAll();
        void Add(EmployeeDto entity);
        void Update(EmployeeDto entity);
        void Delete(EmployeeDto entity);
    }
}
