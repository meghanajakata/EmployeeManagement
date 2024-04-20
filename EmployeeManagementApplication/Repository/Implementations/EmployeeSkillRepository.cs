using EmployeeManagementApplication.Data;
using EmployeeManagementApplication.Models;
using EmployeeManagementApplication.Repository.Interfaces;

namespace EmployeeManagementApplication.Repository.Implementations
{
    public class EmployeeSkillRepository : GenericRepository<EmployeeSkill>, IEmployeeSkillRepository
    {
        public EmployeeSkillRepository(EmployeeManagementApplicationContext context)
            : base(context) { }

    }
}
