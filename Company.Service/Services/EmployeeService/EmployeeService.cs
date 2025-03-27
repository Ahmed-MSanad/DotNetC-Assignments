using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Service.Helper;
using Company.Service.Interfaces.IEmployee;
using Company.Service.Services.EmployeeService.Dto;

namespace Company.Service.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(EmployeeDto employee)
        {
            employee.ImageUrl = DocumentSettings.UploadFile(employee.Image, "Images");
            // Maual Mapping : from view to database
            //Employee mappedEmployee = new Employee
            //{
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    HiringDate = employee.HiringDate,
            //    ImageUrl = employee.ImageUrl,
            //    departmentId = employee.departmentId
            //};
            Employee mappedEmployee = _mapper.Map<Employee>(employee);
            _unitOfWork.EmployeeRepository.Add(mappedEmployee);
            // May do some other stuff here before saving
            // Then save :
            _unitOfWork.Complete();
        }

        public void Delete(EmployeeDto employee)
        {
            // Maual Mapping : from view to database
            Employee mappedEmployee = new Employee
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                ImageUrl = employee.ImageUrl,
                departmentId = employee.departmentId
            };
            _unitOfWork.EmployeeRepository.Delete(mappedEmployee);
            // May do some other stuff here before saving
            // Then save :
            _unitOfWork.Complete();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll();
            // Maual Mapping : from database to view
            var mappedEmployees = employees.Select(employee => new EmployeeDto
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                ImageUrl = employee.ImageUrl,
                departmentId = employee.departmentId,
                CreateAt = employee.CreateAt,
                Id = employee.Id
            });
            return mappedEmployees;
        }

        public EmployeeDto GetById(int? id)
        {
            if (id is null)
                return null;

            var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);

            if (employee is null)
                return null;

            // Maual Mapping : from database to view
            EmployeeDto mappedEmployee = new EmployeeDto
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                ImageUrl = employee.ImageUrl,
                departmentId = employee.departmentId,
                Id = employee.Id,
                CreateAt = employee.CreateAt,
            };

            return mappedEmployee;
        }

        public void Update(EmployeeDto employee)
        {
            //_unitOfWork.EmployeeRepository.Update(employee);
            // May do some other stuff here before saving
            // Then save :
            _unitOfWork.Complete();
        }

        public IEnumerable<EmployeeDto> GetEmployeeByName(string name)
        {
            var employees = _unitOfWork.EmployeeRepository.GetEmployeeByName(name);

            // Maual Mapping : from database to view
            var mappedEmployees = employees.Select(employee => new EmployeeDto
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                ImageUrl = employee.ImageUrl,
                departmentId = employee.departmentId,
                CreateAt = employee.CreateAt,
                Id = employee.Id
            });

            return mappedEmployees;
        }

        public IEnumerable<EmployeeDto> GetEmployeesByAddress(string address)
        {
            var employees = _unitOfWork.EmployeeRepository.GetEmployeesByAddress(address);

            // Maual Mapping : from database to view
            var mappedEmployees = employees.Select(employee => new EmployeeDto
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                ImageUrl = employee.ImageUrl,
                departmentId = employee.departmentId,
                CreateAt = employee.CreateAt,
                Id = employee.Id
            });

            return mappedEmployees;
        }

    }
}
