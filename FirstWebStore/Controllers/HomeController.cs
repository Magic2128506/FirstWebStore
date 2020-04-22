using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Conflict("Home controller - action Index");
        }

        public IActionResult SomeAction()
        {
            return Conflict("Home controller - action SomeAction");
        }
    }
}