using System.ComponentModel.DataAnnotations;
using WebStory.Domain.Entities.Base.Interfaces;

namespace WebStory.Domain.Entities.Base
{
    /// <summary>Именованная сущность</summary>
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        [Required/*, StringLength(250)*/]
        public string Name { get; set; }
    }
}
