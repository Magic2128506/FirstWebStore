using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebStore.Models;
using FirstWebStore.ViewModels;

namespace FirstWebStore.Infrastructure.Mapping
{
    public static class EmployeeMapping
    {
        public static EmployeeViewModel ToView(this Employee employee) => new EmployeeViewModel
        {
            ID = employee.ID,
            Name = employee.FirstName,
            SecondName = employee.SurName,
            Patronymic = employee.Patronymic,
            Age = employee.Age
        };

        public static Employee FromView(this EmployeeViewModel employeeViewModel) => new Employee
        {
            ID = employeeViewModel.ID,
            FirstName = employeeViewModel.Name,
            SurName = employeeViewModel.SecondName,
            Patronymic = employeeViewModel.Patronymic,
            Age = employeeViewModel.Age
        };
    }
}
