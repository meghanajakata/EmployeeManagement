using EmployeeManagementApplication.Data;
using EmployeeManagementApplication.Models;
using EmployeeManagementApplication.Repository.Interfaces;

namespace EmployeeManagementApplication.Repository.Implementations
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        public SkillRepository(EmployeeManagementApplicationContext context) : base(context) { }

    }
}
