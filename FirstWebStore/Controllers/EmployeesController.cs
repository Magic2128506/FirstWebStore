using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.Infrastructure.Mapping;
using FirstWebStore.Models;
using FirstWebStore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebStory.Domain.Entities.Identity;

namespace FirstWebStore.Controllers
{
    //[Route("users")]
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesController(IEmployeesData EmployeesData)
        {
            _EmployeesData = EmployeesData;
        }

        //[Route("")]
        public IActionResult Index() => View(_EmployeesData.GetAll().Select(EmployeeMapping.ToView));

        //[Route("id/{id}")]
        public IActionResult Details(int id)
        {
            var employee = _EmployeesData.GetById(id);

            if (employee == null)
                return NotFound();

            return View(employee.ToView());
        }

        [Authorize(Roles = Role.Administrator)]
        public IActionResult Create()
        {
            return View(new EmployeeViewModel());
        }

        [Authorize(Roles = Role.Administrator)]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (!ModelState.IsValid)
                return View(employee);

            _EmployeesData.Add(employee.FromView());
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = Role.Administrator)]
        public IActionResult Edit(int? id)
        {
            if (id is null)
                return View(new EmployeeViewModel());

            if (id < 0)
                return BadRequest();

            var employee = _EmployeesData.GetById((int)id);

            if (employee is null)
                return NotFound();

            return View(employee.ToView());
        }

        [Authorize(Roles = Role.Administrator)]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            if (employeeViewModel is null)
                throw new ArgumentNullException(nameof(Employee));

            if (employeeViewModel.Name == "ааа" && employeeViewModel.Age == 20)
                ModelState.AddModelError("Name", "Странный человек");

            if (!ModelState.IsValid)
                return View(employeeViewModel);

            var id = employeeViewModel.ID;

            if (id == 0)
                _EmployeesData.Add(employeeViewModel.FromView());
            else
                _EmployeesData.Edit(id, employeeViewModel.FromView());

            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = Role.Administrator)]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var employee = _EmployeesData.GetById(id);

            if (employee is null)
                return NotFound();

            return View(employee.ToView());
        }

        [Authorize(Roles = Role.Administrator)]
        public IActionResult DeleteConfirmed(int id)
        {
            _EmployeesData.Delete(id);
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}