using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStory.Domain.Entities.Base.Interfaces;

namespace FirstWebStore.ViewModels
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
