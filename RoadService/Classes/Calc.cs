using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public static class Calc
    {
        public static decimal GetPlannedPrice(Task task)
        {
            decimal price = 0;
            int hours = (task.TimeEnd - task.TimeStart).Hours;
            
            foreach(var employee in task.Employees)
            {
                price += employee.WagePerHour * hours;
            }

            foreach(var resource in task.PlannedResources)
            {
                if (resource is Material) 
                {
                    price += resource.Price;
                }
                else
                {
                    price += (resource.Price / 5000 + 100) * hours;
                }
            }
            return price;
        }

        public static decimal GetActualPrice(Task task)
        {
            decimal price = 0;
            int hours = (task.TimeEnd - task.TimeStart).Hours;

            foreach (var employee in task.Employees)
            {
                price += employee.WagePerHour * hours;
            }

            foreach (var resource in task.ActualResources)
            {
                if (resource is Material)
                {
                    price += resource.Price;
                }
                else
                {
                    price += (resource.Price / 5000 + 100) * hours;
                }
            }
            return price;
        }
    }
}
