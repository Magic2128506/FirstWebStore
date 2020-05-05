using FirstWebStore.ViewModels.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View(new RegisterUserViewModel());
        }

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
    }
}