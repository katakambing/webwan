using Microsoft.AspNetCore.Mvc;
using WebApplication_ElectricityBill.Models;

namespace WebApplication_ElectricityBill.Controllers
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
