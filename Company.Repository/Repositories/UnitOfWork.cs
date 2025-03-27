using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using Company.Repository.Interfaces;

namespace Company.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork // We will register the UnitOfWork instead of registering every repository alone and from it we can access any of them.
    {
        private readonly CompanyDbContext _context;

        public UnitOfWork(CompanyDbContext context)
        {
            _context = context;
            // We will create the injected repositories here.
            DepartmentRepository = new DepartmentRepository(_context);
            EmployeeRepository = new EmployeeRepository(_context);
        }
        public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }

        public int Complete()
            => _context.SaveChanges();
    }
}
