using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.ViewModels.Identity
{
    public class LoginViewModel
    {
        [Display(Name = "Имя пользователя")]
        [MaxLength(256)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня!")]
        public bool RememberMe { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}
