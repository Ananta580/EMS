using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMS.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
        public DateTime JoinedDate { get; set; }
        public ICollection<EmployeeMapProject> EmployeeMapProjects { get; set; }
    }
}
