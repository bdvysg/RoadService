using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Address { get; set; }
        public decimal PlannedPrice { get; set; }
        public decimal ActualPrice { get; set; }
        [ForeignKey("EmployeeId")]
        public List<Employee> Employees { get; set; }
        [ForeignKey("PlannedResourceId")]
        public List<Resource> PlannedResources { get; set; }
        [ForeignKey("ActualResourcesId")]
        public List<Resource> ActualResources { get; set; }

    }
}
