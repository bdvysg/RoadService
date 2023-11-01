using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class EmployeeTimeTable
    {
        private readonly List<EmployeeTimeTableItem> _items;

        public EmployeeTimeTable()
        {
            // обращение к бд
        }

        public List<Employee> GetEmployees(DateTime timeStart, DateTime timeEnd)
        {
            List<Employee> employees = _items.Where(u=> u.TimeStart >= timeStart && u.TimeEnd < timeEnd)
                                             .Select(u => u.Employee).ToList();
            return employees;
        }

        public void ReserveEmployee(Employee employee, DateTime timeStart, DateTime timeEnd)
        {
            // добавление EmployeeTimeTableItem в бд
        }

        public void UnReserveEmployee(Employee employee, DateTime timeStart, DateTime timeEnd)
        {
            // удаление EmployeeTimeTableItem в бд
        }
    }
}
