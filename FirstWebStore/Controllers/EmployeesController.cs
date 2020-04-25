using System;
using FirstWebStore.Data;
using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.Models;
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
        public IActionResult Index() => View(_EmployeesData.GetAll());

        //[Route("id/{id}")]
        public IActionResult Details(int id)
        {
            var employee = _EmployeesData.GetById(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        public IActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (!ModelState.IsValid)
                return View(employee);

            _EmployeesData.Add(employee);
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null)
                return View(new Employee());

            if (id < 0)
                return BadRequest();

            var employee = _EmployeesData.GetById((int) id);

            if (employee is null)
                return NotFound();

            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (!ModelState.IsValid)
                return View(employee);

            var id = employee.ID;

            if (id == 0)
                _EmployeesData.Add(employee);
            else
                _EmployeesData.Edit(id, employee);

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

            return View(employee);
        }

        public IActionResult DeleteConfirmed(int id)
        {
            _EmployeesData.Delete(id);
            _EmployeesData.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}