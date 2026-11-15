using Microsoft.AspNetCore.Mvc;
using WebApplication_TempConverter.Models;

namespace WebApplication_TempConverter.Controllers
{
    public class TempController : Controller
    {
        // GET: Displays the initial form
        [HttpGet]
        public IActionResult TempView()
        {
            return View();
        }

        // POST: Receives form data and performs conversion
        [HttpPost]
        public IActionResult TempView(TempModel temp)
        {
            temp.ConvertTemperature();
            return View(temp);
        }
    }
}
