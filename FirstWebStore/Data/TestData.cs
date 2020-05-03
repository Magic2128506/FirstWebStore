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
              new Section { ID = 2, Name = "Nike", Order = 0, ParentId = 1 },
              new Section { ID = 3, Name = "Under Armour", Order = 1, ParentId = 1 },
              new Section { ID = 4, Name = "Adidas", Order = 2, ParentId = 1 },
              new Section { ID = 5, Name = "Puma", Order = 3, ParentId = 1 },
              new Section { ID = 6, Name = "ASICS", Order = 4, ParentId = 1 },
              new Section { ID = 7, Name = "Для мужчин", Order = 1 },
              new Section { ID = 8, Name = "Fendi", Order = 0, ParentId = 7 },
              new Section { ID = 9, Name = "Guess", Order = 1, ParentId = 7 },
              new Section { ID = 10, Name = "Valentino", Order = 2, ParentId = 7 },
              new Section { ID = 11, Name = "Диор", Order = 3, ParentId = 7 },
              new Section { ID = 12, Name = "Версачи", Order = 4, ParentId = 7 },
              new Section { ID = 13, Name = "Армани", Order = 5, ParentId = 7 },
              new Section { ID = 14, Name = "Prada", Order = 6, ParentId = 7 },
              new Section { ID = 15, Name = "Дольче и Габбана", Order = 7, ParentId = 7 },
              new Section { ID = 16, Name = "Шанель", Order = 8, ParentId = 7 },
              new Section { ID = 17, Name = "Гуччи", Order = 9, ParentId = 7 },
              new Section { ID = 18, Name = "Для женщин", Order = 2 },
              new Section { ID = 19, Name = "Fendi", Order = 0, ParentId = 18 },
              new Section { ID = 20, Name = "Guess", Order = 1, ParentId = 18 },
              new Section { ID = 21, Name = "Valentino", Order = 2, ParentId = 18 },
              new Section { ID = 22, Name = "Dior", Order = 3, ParentId = 18 },
              new Section { ID = 23, Name = "Versace", Order = 4, ParentId = 18 },
              new Section { ID = 24, Name = "Для детей", Order = 3 },
              new Section { ID = 25, Name = "Мода", Order = 4 },
              new Section { ID = 26, Name = "Для дома", Order = 5 },
              new Section { ID = 27, Name = "Интерьер", Order = 6 },
              new Section { ID = 28, Name = "Одежда", Order = 7 },
              new Section { ID = 29, Name = "Сумки", Order = 8 },
              new Section { ID = 30, Name = "Обувь", Order = 9 },
        };

        public static IEnumerable<Product> Products { get; } = new[]
        {
            new Product { ID = 1, Name = "Белое платье Adidas", Price = 105, ImageUrl = "product1.jpg", Order = 0, SectionId = 2, BrandId = 1 },
            new Product { ID = 2, Name = "Розовое платье", Price = 1023, ImageUrl = "product2.jpg", Order = 1, SectionId = 2, BrandId = 1 },
            new Product { ID = 3, Name = "Красное платье", Price = 1025, ImageUrl = "product3.jpg", Order = 2, SectionId = 2, BrandId = 1 },
            new Product { ID = 4, Name = "Джинсы", Price = 65, ImageUrl = "product4.jpg", Order = 3, SectionId = 2, BrandId = 1 },
            new Product { ID = 5, Name = "Лёгкая майка", Price = 176, ImageUrl = "product5.jpg", Order = 4, SectionId = 2, BrandId = 2 },
            new Product { ID = 6, Name = "Лёгкое голубое поло", Price = 3467, ImageUrl = "product6.jpg", Order = 5, SectionId = 2, BrandId = 1 },
            new Product { ID = 7, Name = "Платье белое", Price = 9325, ImageUrl = "product7.jpg", Order = 6, SectionId = 2, BrandId = 1 },
            new Product { ID = 8, Name = "Костюм кролика", Price = 943, ImageUrl = "product8.jpg", Order = 7, SectionId = 25, BrandId = 1 },
            new Product { ID = 9, Name = "Красное китайское платье", Price = 63, ImageUrl = "product9.jpg", Order = 8, SectionId = 25, BrandId = 1 },
            new Product { ID = 10, Name = "Женские джинсы", Price = 821, ImageUrl = "product10.jpg", Order = 9, SectionId = 25, BrandId = 3 },
            new Product { ID = 11, Name = "Джинсы женские", Price = 8156, ImageUrl = "product11.jpg", Order = 10, SectionId = 25, BrandId = 3 },
            new Product { ID = 12, Name = "Летний костюм", Price = 638, ImageUrl = "product12.jpg", Order = 11, SectionId = 25, BrandId = 3 },
        };
    }
}
