using Microsoft.AspNetCore.Mvc;
using WebApplication_Lab1_Wan.Models;

namespace WebApplication_Lab1_Wan.Controllers
{
    public class TempController : Controller
    {
        [HttpGet]
        public IActionResult TempView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TempView(TempModel temp)
        {
            temp.CalculateTemperature();
            return View(temp);
        }
    }
}
