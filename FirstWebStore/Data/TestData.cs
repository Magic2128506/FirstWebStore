using FirstWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebStore.Data
{
    public class TestData
    {
        public static List<Employee> Employees { get; } = new List<Employee>()
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
    }
}
