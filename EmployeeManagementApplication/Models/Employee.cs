using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApplication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Details { get; set; }
        public float Experience { get; set; }
        public string Projects { get; set; }

    }
}
