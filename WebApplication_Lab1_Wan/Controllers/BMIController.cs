using Microsoft.AspNetCore.Mvc;
using WebApplication_Lab1_Wan.Models;

namespace WebApplication_Lab1_Wan.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMI bmi)
        {
            bmi.CalculateBMI();
            return View(bmi);
        }
    }
}
