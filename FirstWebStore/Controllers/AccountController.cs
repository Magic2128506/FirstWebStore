using System.Threading.Tasks;
using FirstWebStore.ViewModels.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebStory.Domain.Entities.Identity;

namespace FirstWebStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _UserManager;
        private readonly SignInManager<User> _SignInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View(new RegisterUserViewModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User
            {
                UserName = model.UserName
            };

            var registerResult = await _UserManager.CreateAsync(user, model.Password);

            if (registerResult.Succeeded)
            {
                await _SignInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var error in registerResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var loginResult = await _SignInManager.PasswordSignInAsync(
                model.UserName,
                model.Password,
                model.RememberMe,
                false);

            if (loginResult.Succeeded)
            {
                if (Url.IsLocalUrl(model.ReturnUrl))
                    return Redirect(model.ReturnUrl);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Не верное имя пользователя или пароль");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _SignInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}