using System.Linq;
using FirstWebStore.Data;
using FirstWebStore.Infrastructure.Interfaces;
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
    }
}