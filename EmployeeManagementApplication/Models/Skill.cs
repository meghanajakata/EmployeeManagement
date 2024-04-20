﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApplication.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
