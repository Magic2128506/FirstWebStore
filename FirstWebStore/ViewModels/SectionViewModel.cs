using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStory.Domain.Entities.Base.Interfaces;

namespace FirstWebStore.ViewModels
{
    public class SectionViewModel : INamedEntity, IOrderedEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public List<SectionViewModel> ChildSections { get; set; } = new List<SectionViewModel>();
        public SectionViewModel ParentSection { get; set; }
    }
}
