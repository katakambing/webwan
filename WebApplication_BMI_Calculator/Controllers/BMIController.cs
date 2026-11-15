using Microsoft.AspNetCore.Mvc;
using WebApplication_BMI_Calculator.Models;

namespace WebApplication_BMI_Calculator.Controllers
{
    public class BMIController : Controller
    {
        // GET: Loads the form initial state
        [HttpGet]
        public IActionResult BMIView()
        {
            return View();
        }

        // POST: Form submission from browser
        [HttpPost]
        public IActionResult BMIView(BMIModel bmi)
        {
            bmi.CalculateBMI();
            return View(bmi);
        }
    }
}