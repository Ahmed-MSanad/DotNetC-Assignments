using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Service.Interfaces.IDepartment;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Company.Service.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public void Add(Department department)
        {
            var mappedDepartment = new Department
            {
                Name = department.Name,
                Code = department.Code,
                CreateAt = department.CreateAt
            };
            _departmentRepository.Add(mappedDepartment);
        }

        public void Delete(Department department)
        {
            _departmentRepository.Delete(department);
        }

        public IEnumerable<Department> GetAll()
        {
            var deprtments = _departmentRepository.GetAll();
            return deprtments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
                return null;
            
            var department = _departmentRepository.GetById(id.Value);

            if(department is null)
                return null;

            return department;
        }

        public void Update(Department department)
        {
            var departmentToUpdate = _departmentRepository.GetById(department.Id);

            if (department.Name != departmentToUpdate.Name && GetAll().Any(x => x.Name == department.Name))
            {
                throw new Exception("Department Name already exists");
            }

            departmentToUpdate.Name = department.Name;
            departmentToUpdate.Code = department.Code;

            _departmentRepository.Update(departmentToUpdate);
        }
    }
}
