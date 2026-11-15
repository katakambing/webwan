using Microsoft.AspNetCore.Mvc;

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
        public IActionResult MCQView(string Answer)
        {
            ViewBag.AnswerBag = Answer;

            string[] answersArray = { "a", "b", "c", "d", "e" };
            int index = Array.IndexOf(answersArray, Answer);
            ViewBag.IndexBag = index;

            string[] nameArray = { "HTML", "JavaScript", "C#", "CSS", "AJAX" };
            ViewBag.NameBag = index >= 0 ? nameArray[index] : "";

            return View();
        }
    }
}
