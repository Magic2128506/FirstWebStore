using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SomeAction()
        {
            return View();
        }
    }
}