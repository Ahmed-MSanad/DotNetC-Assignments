

using Company.Data.Models;
using Company.Service.Services.DepartmentService.Dto;

namespace Company.Service.Interfaces.IDepartment
{
    public interface IDepartmentService
    {
        DepartmentDto GetById(int? id);
        IEnumerable<DepartmentDto> GetAll();
        void Add(DepartmentDto department);
        void Update(DepartmentDto department);
        void Delete(DepartmentDto department);
    }
}
