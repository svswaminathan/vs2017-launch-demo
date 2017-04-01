using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vs2017mvc.Models;
using Newtonsoft.Json;

namespace vs2017mvc.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client;
        public HomeController()
        {
            client = new HttpClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public async Task<IActionResult> Session()
        {
            var response = await client.GetStringAsync("http://localhost:50357/api/sessions");
            //var response = await client.GetStringAsync("http://dotnetblrwebapi:8000/api/sessions");
            var sessions = JsonConvert.DeserializeObject<List<Session>>(response);
            ViewData["Message"] = "Sessions";
            return View(sessions);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
