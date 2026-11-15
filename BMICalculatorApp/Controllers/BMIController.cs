using Microsoft.AspNetCore.Mvc;
using BMICalculatorApp.Models;

namespace BMICalculatorApp.Controllers
{
    public class BMIController : Controller
    {
        // [HttpGet] Displays the initial page
        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        // [HttpPost] Handles form submission and calculates BMI
        [HttpPost]
        public IActionResult BMICalculator(BMI bmi)
        {
            bmi.CalculateBMI();
            return View(bmi);
        }
    }
}
