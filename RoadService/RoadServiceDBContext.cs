using Microsoft.EntityFrameworkCore;
using RoadService.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadService
{
    public class RoadServiceDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Tool> Tools { get; set; } 
        public DbSet<Transport> Transports { get; set; } 
        public DbSet<Material> Materials { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<EmployeeTimeTableItem> EmployeeTimeTableItems { get; set; }
        public DbSet<ResourceTimeTableItem> ResourceTimeTableItems { get; set; }
        public DbSet<Classes.Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=road_service.db");
        }

    }
}
