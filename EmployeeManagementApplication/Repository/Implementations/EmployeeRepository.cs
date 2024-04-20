using EmployeeManagementApplication.Data;
using EmployeeManagementApplication.Models;
using EmployeeManagementApplication.Repository.Interfaces;

namespace EmployeeManagementApplication.Repository.Implementations
{
    public class EmployeeRepository :  GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeManagementApplicationContext context) : base(context)
        {

        }

    }
}
