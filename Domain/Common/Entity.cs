namespace Domain.Common;

public abstract class Entity<TIdentity>
{
    public Entity(TIdentity id)
    {
        Id = id;
    }

    public TIdentity Id { get; set; }

    private List<Event> _events = new List<Event>();
    public IReadOnlyCollection<Event> Events => _events.AsReadOnly();

    public void RegisterEvent(Event @event)
    {
        _events.Add(@event);
    }

    public void ClearEvent()
    {
        _events.Clear();
    }
}
