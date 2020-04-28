using FirstWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStory.Domain.Entities;

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

        public static IEnumerable<Brand> Brands { get; } = new[]
        {
            new Brand { ID = 1, Name = "Adidas", Order = 0 },
            new Brand { ID = 2, Name = "Barbur", Order = 1 },
            new Brand { ID = 3, Name = "Carhartt", Order = 2 },
            new Brand { ID = 4, Name = "Dell", Order = 3 },
            new Brand { ID = 5, Name = "Edwin", Order = 4 },
            new Brand { ID = 6, Name = "Fred Perry", Order = 5 },
            new Brand { ID = 7, Name = "Hennessy", Order = 6 }
        };

        public static IEnumerable<Section> Sections { get; } = new[]
{
            new Section { ID = 1, Name = "Спорт", Order = 0 },
            new Section { ID = 2, Name = "Спорт2", Order = 0, ParentId = 1 },
            new Section { ID = 3, Name = "Спорт3", Order = 1, ParentId = 1 },
            new Section { ID = 4, Name = "Спорт4", Order = 2, ParentId = 1 },
            new Section { ID = 5, Name = "Спорт5", Order = 3, ParentId = 1 },
            new Section { ID = 6, Name = "Спорт6", Order = 4, ParentId = 1 },
            new Section { ID = 7, Name = "Для мужчин", Order = 1 },
            new Section { ID = 8, Name = "Спорт8", Order = 0, ParentId = 1 },
            new Section { ID = 9, Name = "Спорт9", Order = 1, ParentId = 7 },
            new Section { ID = 10, Name = "Спорт10", Order = 2, ParentId = 7 },
            new Section { ID = 11, Name = "Спорт11", Order = 3, ParentId = 7 },
            new Section { ID = 12, Name = "Спорт12", Order = 4, ParentId = 7 },
            new Section { ID = 13, Name = "Спорт13", Order = 5, ParentId = 7 },
            new Section { ID = 14, Name = "Спорт14", Order = 6, ParentId = 7 },
            new Section { ID = 15, Name = "Спорт15", Order = 7, ParentId = 7 },
            new Section { ID = 16, Name = "Спорт16", Order = 8, ParentId = 7 },
            new Section { ID = 17, Name = "Спорт17", Order = 9, ParentId = 7 },
            new Section { ID = 18, Name = "Для женщин", Order = 2 },
            new Section { ID = 19, Name = "Fendi19", Order = 0, ParentId = 18 },
            new Section { ID = 20, Name = "Guess", Order = 1, ParentId = 18 },
            new Section { ID = 21, Name = "Valentino", Order = 2, ParentId = 18 },
            new Section { ID = 22, Name = "Dior", Order = 3, ParentId = 18 },
            new Section { ID = 23, Name = "Версаче", Order = 4, ParentId = 18 },
            new Section { ID = 24, Name = "Для детей", Order = 3, ParentId = 18 },
            new Section { ID = 25, Name = "Мода", Order = 4, ParentId = 18 },
            new Section { ID = 26, Name = "Для дома", Order = 5, ParentId = 18 },
            new Section { ID = 27, Name = "Интерьер", Order = 6, ParentId = 18 },
            new Section { ID = 28, Name = "Одежда", Order = 7, ParentId = 18 },
            new Section { ID = 29, Name = "Сумки", Order = 8, ParentId = 18 },
            new Section { ID = 30, Name = "Обувь", Order = 9, ParentId = 18 },
        };
    }
}
