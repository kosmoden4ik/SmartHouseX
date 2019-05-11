using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SmartHouse.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<DeviceDBContext>
    {
        protected override void Seed(DeviceDBContext db)
        {
            db.Devices.Add(new DeviceModels { macadress="323ejk:dslkd", status="on", type_device="onoffer", last_activ_time=DateTime.Today});
            db.Devices.Add(new DeviceModels { macadress = "3123dsajk:dslkd", status = "termometr", type_device = "Tempar", last_activ_time = DateTime.Today });
            db.Devices.Add(new DeviceModels { macadress = "3213asd:dslkd", status = "obogrev", type_device = "OnOffT", last_activ_time = DateTime.Today });
            db.Devices.Add(new DeviceModels { macadress = "jls98jk:dslkd", status = "move", type_device = "Ring", last_activ_time = DateTime.Today });
            base.Seed(db);
        }
    }
}