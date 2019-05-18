using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartHouse.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var device = await GetDevice();
            ViewBag.device = device.macadress;
            return View();
        }
        private async Task<DeviceModels> GetDevice()
        {
            var device = new DeviceModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("http://localhost:1976/");
                var response = await client.GetAsync("/api/app/GetUser");
                device.macadress = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : "<h1>Null</h1>";

            }
            return device;
        }
        /*   public ActionResult Index()
           {
               return View();
           }*/

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("~/Views/Home/About.cshtml");
        }
        public ActionResult HowConnect()
        {

            return View();
        }

        public ActionResult Contact()
        {
           
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}