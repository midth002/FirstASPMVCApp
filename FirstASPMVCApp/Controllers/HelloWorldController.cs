using Microsoft.AspNetCore.Mvc;
using FirstASPMVCApp.Models;

namespace FirstASPMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name = "Ollie", Age = 1 }; 
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View();
        }

        public string Hello()
        {
            return "Who's there";

        }
    }
}
