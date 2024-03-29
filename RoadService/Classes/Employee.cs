﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Position { get; set; } 
        public DateTime HireDate { get; set; }
        public decimal WagePerHour { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

}
