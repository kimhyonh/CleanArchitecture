using MediatR;

namespace Domain.Common;

public abstract class Event : INotification
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
