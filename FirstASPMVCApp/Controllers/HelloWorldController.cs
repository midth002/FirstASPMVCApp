using Microsoft.AspNetCore.Mvc;

namespace FirstASPMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            return "Who's there";

        }
    }
}
