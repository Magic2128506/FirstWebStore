using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
