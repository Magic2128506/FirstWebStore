using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Components
{
    //[ViewComponent(Name = "Section")]
    public class SectionsViewComponent : ViewComponent
    {
        private readonly IProductData _ProductData;

        public SectionsViewComponent(IProductData productData)
        {
            _ProductData = productData;
        }

        //public async Task<IViewComponentResult> InvokeAsynk() { }
        public IViewComponentResult Invoke() => View(GetSections());

        private IEnumerable<SectionViewModel> GetSections()
        {
            var sections = _ProductData.GetSections().ToArray();

            var parentSections = sections.Where(x => x.ParentId is null);
            var parentSectionsView = parentSections
                .Select(s => new SectionViewModel 
                {
                    ID = s.ID,
                    Name = s.Name,
                    Order = s.Order
                })
                .ToList();

            foreach (var parentSection in parentSectionsView)
            {
                var childs = sections.Where(x => x.ParentId == parentSection.ID);

                foreach (var child in childs)
                {
                    parentSection.ChildSections.Add(new SectionViewModel
                    {
                        ID = child.ID,
                        Name = child.Name,
                        Order = child.Order,
                        ParentSection = parentSection
                    });
                }

                parentSection.ChildSections.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));
            }

            parentSectionsView.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));

            return parentSectionsView;
        }
    }
}
