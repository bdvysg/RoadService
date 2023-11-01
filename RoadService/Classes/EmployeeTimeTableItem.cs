using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class EmployeeTimeTableItem
    {
        public Employee Employee{ get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        public EmployeeTimeTableItem(Employee employee, DateTime timeStart, DateTime timeEnd) 
        {
            Employee = employee;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }
    }
}
