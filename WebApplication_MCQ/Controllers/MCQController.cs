using Microsoft.AspNetCore.Mvc;
using WebApplication_MCQ.Models;

namespace WebApplication_MCQ.Controllers
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