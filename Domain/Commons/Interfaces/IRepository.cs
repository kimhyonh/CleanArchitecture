namespace Domain.Common.Interfaces;

public interface IRepository<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
{
    IReadOnlyCollection<TAggregateRoot> GetAll();
}
