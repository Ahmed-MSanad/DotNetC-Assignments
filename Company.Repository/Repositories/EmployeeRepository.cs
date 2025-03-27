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
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmployeeRepository(CompanyDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployeeByName(string text)
            => _context.Set<Employee>().Where(x =>
                                                    x.Name.Trim().ToLower().Contains(text.Trim().ToLower())
                                                    || x.Email.Trim().ToLower().Contains(text.Trim().ToLower()) 
                                                    || x.PhoneNumber.Trim().ToLower().Contains(text.Trim().ToLower())
                                             ).ToList();

        public IEnumerable<Employee> GetEmployeesByAddress(string address)
            => _context.Set<Employee>().Where(x => x.Address.Trim().ToLower().Contains(address.Trim().ToLower())).ToList();
    }
}
