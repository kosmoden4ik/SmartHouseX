using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SmartHouse.Models
{
    public class DeviceDBContext:DbContext
    {
        public DbSet<DeviceModels> Devices { get; set; }
    }
}