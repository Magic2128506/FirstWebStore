using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.Infrastructure.Mapping;
using FirstWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WebStory.Domain.Entities;

namespace FirstWebStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData _ProductData;

        public CatalogController(IProductData productData)
        {
            _ProductData = productData;
        }

        public IActionResult Shop(int? SectionId, int? BrandId)
        {
            var filter = new ProductFilter
            {
                BrandId = BrandId,
                SectionId = SectionId
            };

            var products = _ProductData.GetProducts(filter);

            return View(new CatalogViewModel
            {
                SectionId = SectionId,
                BrandId = BrandId,
                Products = products
                    //.Select(p => p.ToView()) - строка ниже одно и то же
                    .Select(ProductMapping.ToView)
                    .OrderBy(p => p.Order)
            });
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}