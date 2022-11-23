using Microsoft.AspNetCore.Mvc;
using SignalR.Models;
using System.Diagnostics;

namespace SignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public IActionResult Index()
        {
            return View();
        }


    }
}
