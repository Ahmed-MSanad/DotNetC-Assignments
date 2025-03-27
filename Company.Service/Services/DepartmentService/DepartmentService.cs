using AutoMapper;
using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Service.Interfaces.IDepartment;
using Company.Service.Services.DepartmentService.Dto;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Company.Service.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(DepartmentDto department)
        {
            //Department mappedDepartment = _mapper.Map<DepartmentDto, Department>(department);
            Department mappedDepartment = _mapper.Map<Department>(department);
            _unitOfWork.DepartmentRepository.Add(mappedDepartment);
            // May do some other stuff here before saving
            // Then save :
            _unitOfWork.Complete();
        }

        public void Delete(DepartmentDto department)
        {
            Department mappedDepartment = _mapper.Map<Department>(department);
            _unitOfWork.DepartmentRepository.Delete(mappedDepartment);
            // May do some other stuff here before saving
            // Then save :
            _unitOfWork.Complete();
        }

        public IEnumerable<DepartmentDto> GetAll()
        {
            var departments = _unitOfWork.DepartmentRepository.GetAll();
            IEnumerable<DepartmentDto> mappedDepartment = _mapper.Map<IEnumerable<DepartmentDto>>(departments);
            return mappedDepartment;
        }

        public DepartmentDto GetById(int? id)
        {
            if (id is null)
                return null;
            
            var department = _unitOfWork.DepartmentRepository.GetById(id.Value);
            DepartmentDto mappedDepartment = _mapper.Map<DepartmentDto>(department);

            if (department is null)
                return null;

            return mappedDepartment;
        }

        public void Update(DepartmentDto department)
        {
            var departmentToUpdate = _unitOfWork.DepartmentRepository.GetById(department.Id);

            if (department.Name != departmentToUpdate.Name && GetAll().Any(x => x.Name == department.Name))
            {
                throw new Exception("Department Name already exists");
            }

            departmentToUpdate.Name = department.Name;
            departmentToUpdate.Code = department.Code;

            _unitOfWork.DepartmentRepository.Update(departmentToUpdate);
            // May do some other stuff here before saving
            // Then save :
            _unitOfWork.Complete();
        }
    }
}
