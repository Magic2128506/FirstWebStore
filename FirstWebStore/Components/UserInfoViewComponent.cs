using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Components
{
    public class UserInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
            => User.Identity?.IsAuthenticated == true
            ? View("UserInfo")
            : View();

        //public IViewComponentResult Invoke() => User.Identity?.IsAuthenticated == true
        //    ? User.IsInRole(Role.Administrator)
        //        ? View("AdminInfo")
        //        : View("UserInfo")
        //    : View();
    }
}
