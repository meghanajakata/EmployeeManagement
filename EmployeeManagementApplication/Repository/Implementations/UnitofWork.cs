using EmployeeManagementApplication.Data;
using EmployeeManagementApplication.Models;
using EmployeeManagementApplication.Repository.Interfaces;

namespace EmployeeManagementApplication.Repository.Implementations
{
    public class UnitofWork : IUnitofWork
    {
        private EmployeeManagementApplicationContext _context;
        public  IEmployeeRepository Employees {  get; set; }
        public UnitofWork(EmployeeManagementApplicationContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }

    }
}
