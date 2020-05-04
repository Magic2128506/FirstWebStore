using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStory.Domain.Entities.Base;
using WebStory.Domain.Entities.Base.Interfaces;

namespace WebStory.Domain.Entities
{
    /// <summary>Секция товаров</summary>
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        /// <summary>Идентификатор родительской секции</summary>
        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Section ParentSection { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
