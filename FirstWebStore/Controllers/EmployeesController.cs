﻿using System.Collections.Generic;
using System.Linq;
using FirstWebStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> _Employees = new List<Employee>()
        {
            new Employee
            {
                ID = 1,
                FirstName = "Nasibullin",
                SurName = "Timur",
                Patronymic = "Radimovich",
                Age = 29
            },
            new Employee
            {
                ID = 2,
                FirstName = "Haidarshin",
                SurName = "Adel",
                Patronymic = "Valerevich",
                Age = 25
            },
            new Employee
            {
                ID = 3,
                FirstName = "Vahitov",
                SurName = "Roman",
                Patronymic = "Olegovich",
                Age = 27
            }
        };

        public IActionResult Index() => View(_Employees);

        public IActionResult Details(int id)
        {
            var employee = _Employees.FirstOrDefault(x => x.ID == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

    }
}