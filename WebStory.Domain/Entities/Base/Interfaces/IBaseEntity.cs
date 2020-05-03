using System;
using System.Collections.Generic;
using System.Text;

namespace WebStory.Domain.Entities.Base.Interfaces
{
    /// <summary>Базовая сущность</summary>
    public interface IBaseEntity
    {
        /// <summary>Идентификатор</summary>
        int ID { get; set; }
    }
}
