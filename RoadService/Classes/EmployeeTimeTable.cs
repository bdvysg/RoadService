using RoadService.Repository;
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
        private UnitOfWork _unitOfWork;

        public EmployeeTimeTable(UnitOfWork unitOfWork)
        {
            _items = unitOfWork.EmployeeTimeTableItem.GetAll().ToList();
            _unitOfWork = unitOfWork;
        }

        public List<Employee> GetEmployees(DateTime timeStart, DateTime timeEnd)
        {
            var busyWorkerIds = _items.Where(s => (s.TimeStart <= timeEnd && s.TimeEnd >= timeStart)).Select(s => s.EmployeeId).ToList();

            var availableWorkers = _unitOfWork.Employee.GetAll().Where(u => u.Position == "Дорожній працівник").Where(w => !busyWorkerIds.Contains(w.Id)).ToList();

            return availableWorkers;
        }

        public void ReserveEmployee(Employee employee, DateTime timeStart, DateTime timeEnd)
        {
            var emp = new EmployeeTimeTableItem();
            emp.Employee = employee;
            emp.TimeStart = timeStart;
            emp.TimeEnd = timeEnd;
            _unitOfWork.EmployeeTimeTableItem.Add(emp);
            _unitOfWork.Save();
        }

        public void UnReserveEmployee(Employee employee, DateTime timeStart, DateTime timeEnd)
        {
            var emp = new EmployeeTimeTableItem();
            emp.Employee = employee;
            emp.TimeStart = timeStart;
            emp.TimeEnd = timeEnd;
            _unitOfWork.EmployeeTimeTableItem.Remove(emp);
            _unitOfWork.Save();
        }
    }
}
