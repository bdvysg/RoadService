﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [NotMapped]
        public List<Employee> Employees { get; set; }
        [NotMapped]
        public List<Resource> PlannedResources { get; set; }
        [NotMapped]
        public List<Resource> ActualResources { get; set; }
        [DefaultValue(false)]
        public bool isClosed { get; set; }
        public string Status { get; set; }

        [Column("Employees")]
        public string EmployeesSerialized
        {
            get { return JsonConvert.SerializeObject(Employees); }
            set { Employees = JsonConvert.DeserializeObject<List<Employee>>(value); }
        }

        [Column("PlannedResources")]
        public string PlannedResourcesSerialized
        {
            get { return JsonConvert.SerializeObject(PlannedResources); }
            set { PlannedResources = JsonConvert.DeserializeObject<List<Resource>>(value); }
        }

        [Column("ActualResources")]
        public string ActualResourcesSerialized
        {
            get { return JsonConvert.SerializeObject(ActualResources); }
            set { ActualResources = JsonConvert.DeserializeObject<List<Resource>>(value); }
        }

        /*
        string address;
        DateTime date;
        List<Employee> employees;
        List<Resource> resources;
        string desc;
        decimal price;
        bool isAddressValid;
        string status;

        Task t;
        Tariff tf;
        AddressList adr;
        EmployeeTimeTable empTT;
        ResourceTimeTable resTT;

        public Task(Tariff tf, AddressList adr, EmployeeTimeTable empTT, ResourceTimeTable resTT)
        {
            this.tf = tf;
            this.adr = adr;
            this.empTT = empTT;
            this.resTT = resTT;
        }

        public bool isValidAddress(string address)
        {
            return adr.IsValidAddress(address);
        }

        List<Employee> GetEmployees()
        {
            empTT.GetEmployees(date);
        }

        public List<Resource> GetResources()
        {
            resTT.GetResources(date);
        }

        public void reserveEmployees(Employee emp)
        {
            empTT.ReserveEmployee(emp, date);
        }

        public void reserveResources(Resource res)
        {
            resTT.ReserveResorce(res, date);
        }
        */
    }
}
