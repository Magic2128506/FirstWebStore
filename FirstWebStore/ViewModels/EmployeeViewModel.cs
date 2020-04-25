using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FirstWebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя является обязательным")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия является обязательным")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        public string SecondName { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Возраст является обязательным")]
        public int Age { get; set; }
    }
}