namespace Domain.Common;

public abstract class DomainEntity<TIdentity>
{
    public DomainEntity(TIdentity id)
    {
        Id = id;
    }

    public TIdentity Id { get; set; }

    private List<DomainEvent> _events = new List<DomainEvent>();
    public IReadOnlyCollection<DomainEvent> Events => _events.AsReadOnly();

    public void RegisterEvent(DomainEvent @event)
    {
        _events.Add(@event);
    }

    public void ClearEvent()
    {
        _events.Clear();
    }
}
