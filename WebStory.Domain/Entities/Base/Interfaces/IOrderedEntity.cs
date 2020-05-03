namespace WebStory.Domain.Entities.Base.Interfaces
{
    /// <summary>Упорядочиваемая сущность</summary>
    public interface IOrderedEntity : IBaseEntity
    {
        int Order { get; set; }
    }
}
