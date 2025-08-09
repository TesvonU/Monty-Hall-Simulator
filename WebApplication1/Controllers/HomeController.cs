using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Doors doors = new Doors();
            return View(doors);
        }

        [HttpPost]
        public IActionResult Index(Doors doors, int selected, int round)
        {
            if (round == 0)
            {
                doors.SelectDoor1(selected);
            }
            else 
            {
                doors.SelectDoor2(selected);
                
            }
            return View(doors);
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
