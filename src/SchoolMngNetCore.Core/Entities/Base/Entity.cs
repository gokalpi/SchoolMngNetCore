namespace SchoolMngNetCore.Core.Entities.Base
{
    public abstract class Entity : Entity<int> { }

    public abstract class Entity<TId> : IEntity<TId>
    {
        public virtual TId Id { get; protected set; }
    }
}