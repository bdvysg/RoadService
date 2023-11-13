using RoadService.Classes;
using RoadService.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadService.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public Repository<Address> Address {  get; private set; }
        public Repository<User> Users { get; private set; }
        public Repository<Stock> Stock { get; private set; }
        public Repository<Employee> Employee { get; private set; }
        public Repository<EmployeeTimeTableItem> EmployeeTimeTableItem { get; private set; }
        public Repository<Resource> Resource { get; private set; }
        public Repository<ResourceTimeTableItem> ResourceTimeTableItem { get; private set; }
        public Repository<Classes.Task> Task { get; private set; }


        RoadServiceDBContext _dbContext;

        public UnitOfWork(RoadServiceDBContext dbContext)
        {
            _dbContext = dbContext;

            Address = new Repository<Address>(dbContext);
            Employee = new Repository<Employee>(dbContext);
            EmployeeTimeTableItem = new Repository<EmployeeTimeTableItem>(dbContext);
            Resource = new Repository<Resource>(dbContext);
            Users = new Repository<User>(dbContext);
            Stock = new Repository<Stock>(dbContext);
            ResourceTimeTableItem = new Repository<ResourceTimeTableItem>(dbContext);
            Task = new Repository<Classes.Task>(dbContext);

        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
