using System.Linq;
using FirstWebStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    //[Route("users")]
    public class EmployeesController : Controller
    {
        //[Route("")]
        public IActionResult Index() => View(TestData.Employees);

        //[Route("id/{id}")]
        public IActionResult Details(int id)
        {
            var employee = TestData.Employees.FirstOrDefault(x => x.ID == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

    }
}