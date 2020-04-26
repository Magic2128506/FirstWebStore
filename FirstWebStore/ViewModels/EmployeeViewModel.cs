using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FirstWebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [Display(Name = "Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [MinLength(1, ErrorMessage = "Минимум 1 символ")]
        [StringLength(maximumLength: 100, MinimumLength = 1)]
        //[RegularExpression(@"(?:[А-ЯЁ][а-яё]+)|(?:[A-Z][a-z]+)", ErrorMessage = "Имя должно содержать только буквы английского или русского языка")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательным")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        public string SecondName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Возраст")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательным")]
        [Range(minimum: 14, maximum: 150, ErrorMessage ="Возраст должен быть между 14 и 150")]
        public int Age { get; set; }
    }
}