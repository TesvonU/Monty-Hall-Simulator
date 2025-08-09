using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Simulation()
        {
            return View();
        }

        public IActionResult Explanation()
        {
            return View();
        }
        
    }
}
