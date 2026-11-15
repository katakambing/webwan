using Microsoft.AspNetCore.Mvc;
using WebApplication_ElectricityBill.Models;

namespace WebApplication_ElectricityBill.Controllers
{
    public class ElectricityController : Controller
    {
        // GET: Loads initial form page
        [HttpGet]
        public IActionResult ElectricityView()
        {
            return View();
        }

        // POST: Processes unit calculation on form submission
        [HttpPost]
        public IActionResult ElectricityView(ElectricityModel model)
        {
            model.CalculateBill();
            return View(model);
        }
    }
}
