using Microsoft.AspNetCore.Mvc;
using WebApplication_Lab1_Wan.Models;

namespace WebApplication_Lab1_Wan.Controllers
{
    public class PetController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Pet());
        }

        [HttpPost]
        public IActionResult Index(Pet model)
        {
            switch (model.SelectedAnimal)
            {
                case "Dog":
                    model.ImagePath = "/images/Dog.jpg";
                    break;
                case "Cat":
                    model.ImagePath = "/images/Cat.jpg";
                    break;
                case "Bird":
                    model.ImagePath = "/images/Bird.jpg";
                    break;
                case "Fish":
                    model.ImagePath = "/images/Fish.jpg";
                    break;
                default:
                    model.ImagePath = null;
                    break;
            }

            return View(model);
        }
    }
}
