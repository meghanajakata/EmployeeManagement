using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApplication.Models
{
    public class EmployeeSkill
    {
        public int Id { get; set; }
        
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
