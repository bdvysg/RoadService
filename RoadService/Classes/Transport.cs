﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadService.Classes
{
    public class Transport : Resource
    {
        public string VehicleType { get; set; } 
        public string LicensePlate { get; set; } 
        public DateTime LastMaintenanceDate { get; set; } 
    }
}
