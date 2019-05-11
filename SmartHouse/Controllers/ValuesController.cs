using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartHouse.Controllers
{
    public class ValuesController : ApiController
    {
        DeviceDBContext db = new DeviceDBContext();

        public IEnumerable<DeviceModels> GetDevice()
        {
            return db.Devices;
        }
        public DeviceModels GetDevice(int id)
        {
            DeviceModels device = db.Devices.Find(id);
            return device;
        }
        [HttpPost]
        public void CreateDevice([FromBody]DeviceModels device)
        {
            db.Devices.Add(device);
            db.SaveChanges();
        }
        [HttpPut]
        public void EditDevice(int id, [FromBody]DeviceModels device)
        {
            if (id == device.id_Device)
            {
                db.Entry(device).State = EntityState.Modified;

                db.SaveChanges();
            }

        }
        public void DeleteDevice(int id)
        {
            DeviceModels device = db.Devices.Find(id);
            if (device != null)
            {
                db.Devices.Remove(device);
                db.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
