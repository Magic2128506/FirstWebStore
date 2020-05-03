using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStory.Domain.Entities.Base;
using WebStory.Domain.Entities.Base.Interfaces;

namespace WebStory.Domain.Entities
{
    /// <summary>Бренд</summary>
    //[Table("Brands")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
