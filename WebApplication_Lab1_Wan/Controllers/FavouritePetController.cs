using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Lab1_Wan.Controllers
{
    public class FavouritePetController : Controller
    {
        [HttpGet]
        public IActionResult FavouritePetView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FavouritePetView(string pet, string size)
        {
            ViewBag.pet = pet;
            ViewBag.size = size;
            return View();
        }
    }
}
