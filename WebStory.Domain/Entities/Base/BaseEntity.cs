using System;
using System.Collections.Generic;
using System.Text;
using WebStory.Domain.Entities.Base.Interfaces;

namespace WebStory.Domain.Entities.Base
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class BaseEntity : IBaseEntity
    {
        public int ID { get; set; }
    }

    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
