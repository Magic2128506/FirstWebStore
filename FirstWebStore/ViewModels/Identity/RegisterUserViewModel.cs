using System.ComponentModel.DataAnnotations;

namespace FirstWebStore.ViewModels.Identity
{
    public class RegisterUserViewModel
    {
        [Display(Name = "Имя пользователя")]
        [MaxLength(256)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare(nameof(Password), ErrorMessage = "Пароль и подтверждение пароля не совпали кранчик!!!")]
        public string ConfirmPassword { get; set; }
    }
}
