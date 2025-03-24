using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interfaces;

namespace Company.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> ,IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmployeeRepository(CompanyDbContext context) : base(context)
        {
            _context = context;
        }

        public Employee GetEmployeeByName(string name)
            => _context.Set<Employee>().FirstOrDefault(x => x.Name == name);

        public IEnumerable<Employee> GetEmployeesByAddress(string address)
            => _context.Set<Employee>().Where(x => x.Address == address).ToList();
    }
}
