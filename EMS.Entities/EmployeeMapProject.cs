using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class EmployeeMapProject
    {
        public Guid Id { get; set; }
        [ForeignKey("EmployeeId")]
        public Guid EmployeeId { get; set; }
        [ForeignKey("ProjectId")]
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
