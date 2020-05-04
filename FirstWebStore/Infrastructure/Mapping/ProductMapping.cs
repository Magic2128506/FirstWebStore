using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebStore.ViewModels;
using WebStory.Domain.Entities;

namespace FirstWebStore.Infrastructure.Mapping
{
    public static class ProductMapping
    {
        public static ProductViewModel ToView(this Product product) => new ProductViewModel
        {
            ID = product.ID,
            Name = product.Name,
            ImageUrl = product.ImageUrl,
            Order = product.Order,
            Price = product.Price
        };

        public static IEnumerable<ProductViewModel> ToView(this IEnumerable<Product> p) => p.Select(ToView);
    }
}
