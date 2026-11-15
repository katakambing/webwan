using Microsoft.AspNetCore.Mvc;
using WebApplication_Lab1_Wan.Models;

namespace WebApplication_Lab1_Wan.Controllers
{
    public class MCQController : Controller
    {
        [HttpGet]
        public IActionResult MCQView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MCQView(MCQModel model)
        {
            model.CheckAnswer();
            return View(model);
        }
    }
}
