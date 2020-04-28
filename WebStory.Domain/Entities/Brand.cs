using System;
using System.Collections.Generic;
using System.Text;
using WebStory.Domain.Entities.Base;
using WebStory.Domain.Entities.Base.Interfaces;

namespace WebStory.Domain.Entities
{
    /// <summary>Бренд</summary>
    class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
