using SmartHouseX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartHouseX.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var device = await GetDevice();
            return View(device);
        }
        private async Task<DeviceModels> GetDevice()
        {
            var device = new DeviceModels();
            using(var client=new HttpClient())
            {
                client.BaseAddress = new System.Uri("http://localhost:4413/");
                var response = await client.GetAsync("api/App");
                device.macadress=response.IsSuccessStatusCode? await response.Content.ReadAsStringAsync():string.Empty;

            }
            return device;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}