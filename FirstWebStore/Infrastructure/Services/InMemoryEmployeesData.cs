using FirstWebStore.Data;
using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebStore.Infrastructure.Services
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _Employees = TestData.Employees;

        public void Add(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (_Employees.Contains(employee)) 
                return;

            employee.ID = _Employees.Count == 0 ? 1 : _Employees.Max(x => x.ID) + 1;
            _Employees.Add(employee);
        }

        public bool Delete(int id)
        {
            Employee employee = GetById(id);

            if (employee is null)
                return false;
                        
            return _Employees.Remove(employee);
        }

        public void Edit(int id, Employee source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(Employee));

            if (_Employees.Contains(source))
                return;

            var targetEmployee = GetById(id);

            if (targetEmployee != null)
            {
                targetEmployee.FirstName = source.FirstName;
                targetEmployee.SurName = source.SurName;
                targetEmployee.Patronymic = source.Patronymic;
                targetEmployee.Age = source.Age;
            }
        }

        public IEnumerable<Employee> GetAll() => _Employees;

        public Employee GetById(int id) => _Employees.FirstOrDefault(x => x.ID == id);

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
