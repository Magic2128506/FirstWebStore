using FirstWebStore.Data;
using FirstWebStore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStory.Domain.Entities;

namespace FirstWebStore.Infrastructure.Services
{
    public class InMemoruProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Section> GetSections() => TestData.Sections;
    }
}
