using System;
using System.Linq;
using FirstWebStore.Data;
using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.Models;
using FirstWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    //[Route("users")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesController(IEmployeesData EmployeesData)
        {
            _EmployeesData = EmployeesData;
        }

        //[Route("")]
        public IActionResult Index() => View(_EmployeesData.GetAll().Select(x => new EmployeeViewModel
        {
            ID = x.ID,
            Name = x.FirstName,
            SecondName = x.SurName,
            Patronymic = x.Patronymic,
            Age = x.Age
        }));

        //[Route("id/{id}")]
        public IActionResult Details(int id)
        {
            var employee = _EmployeesData.GetById(id);

            if (employee == null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                ID = employee.ID,
                Name = employee.FirstName,
                SecondName = employee.SurName,
                Patronymic = employee.Patronymic,
                Age = employee.Age
            });
        }

        public IActionResult Create()
        {
            return View(new EmployeeViewModel());
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (!ModelState.IsValid)
                return View(employee);

            _EmployeesData.Add(new Employee
            {
                ID = employee.ID,
                FirstName = employee.Name,
                SurName = employee.SecondName,
                Patronymic = employee.Patronymic,
                Age = employee.Age
            });
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null)
                return View(new EmployeeViewModel());

            if (id < 0)
                return BadRequest();

            var employee = _EmployeesData.GetById((int)id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                ID = employee.ID,
                Name = employee.FirstName,
                SecondName = employee.SurName,
                Patronymic = employee.Patronymic,
                Age = employee.Age
            });
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (!ModelState.IsValid)
                return View(employee);

            var id = employee.ID;

            if (id == 0)
                _EmployeesData.Add(new Employee
                {
                    ID = employee.ID,
                    FirstName = employee.Name,
                    SurName = employee.SecondName,
                    Patronymic = employee.Patronymic,
                    Age = employee.Age
                });
            else
                _EmployeesData.Edit(id, new Employee
                {
                    ID = employee.ID,
                    FirstName = employee.Name,
                    SurName = employee.SecondName,
                    Patronymic = employee.Patronymic,
                    Age = employee.Age
                });

            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var employee = _EmployeesData.GetById(id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                ID = employee.ID,
                Name = employee.FirstName,
                SecondName = employee.SurName,
                Patronymic = employee.Patronymic,
                Age = employee.Age
            });
        }

        public IActionResult DeleteConfirmed(int id)
        {
            _EmployeesData.Delete(id);
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}