using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductData _ProductData;

        public BrandsViewComponent(IProductData productData)
        {
            _ProductData = productData;
        }
        public IViewComponentResult Invoke() => View(GetBrands());
        public IEnumerable<BrandViewModel> GetBrands() => _ProductData
            .GetBrands()
            .Select(brand => new BrandViewModel
            {
                ID = brand.ID,
                Name = brand.Name,
                Order = brand.Order
            })
            .OrderBy(brand => brand.Order);
    }
}
