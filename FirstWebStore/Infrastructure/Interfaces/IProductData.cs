using System.Collections.Generic;
using WebStory.Domain.Entities;

namespace FirstWebStore.Infrastructure.Interfaces
{
    /// <summary>
    /// Каталог товаров
    /// </summary>
    public interface IProductData
    {
        /// <summary>Получить все секции</summary>
        /// <returns>Перечисление секций каталога</returns>
        IEnumerable<Section> GetSections();

        /// <summary>Получить все бренды</summary>
        /// <returns>Перечисление брендов каталога</returns>
        IEnumerable<Brand> GetBrands();

        /// <summary>Товары из каталога</summary>
        /// <param name="filter">Критерий поиска</param>
        /// <returns>Искомые товары из каталога товаров</returns>
        IEnumerable<Product> GetProducts(ProductFilter filter = null);

        /// <summary>Получить товар по идентификатору</summary>
        /// <param name="id">Идентификатор товара</param>
        /// <returns>Товар</returns>
        Product GetProductById(int id);
    }
}
