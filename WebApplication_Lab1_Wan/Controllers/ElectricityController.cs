using Microsoft.AspNetCore.Mvc;
using WebApplication_Lab1_Wan.Models;

namespace WebApplication_Lab1_Wan.Controllers
{
    public class ElectricityController : Controller
    {
        [HttpGet]
        public IActionResult ElectricityView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ElectricityView(ElectricityModel model)
        {
            model.CalculateBill();
            return View(model);
        }
    }
}
