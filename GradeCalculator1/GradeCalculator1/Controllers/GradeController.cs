using Microsoft.AspNetCore.Mvc;
using GradeCalculator.Models;

namespace GradeCalculator.Controllers
{
    public class GradeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new GradeModel());
        }

        [HttpPost]
        public IActionResult Index(GradeModel model)
        {
            // Test 15%, Assignment 15%, Project 30%, Final Exam 40%
            double overall = (model.Test / 25.0 * 15)
                           + (model.Assignment / 50.0 * 15)
                           + (model.Project / 75.0 * 30)
                           + (model.FinalExam / 100.0 * 40);

            model.OverallMark = overall;

            if (overall >= 75)
            {
                model.Grade = "A";
            }
            else if (overall >= 65)
            {
                model.Grade = "B";
            }
            else if (overall >= 55)
            {
                model.Grade = "C";
            }
            else if (overall >= 45)
            {
                model.Grade = "D";
            }
            else
            {
                model.Grade = "F";
            }

            return View(model);
        }
    }
}