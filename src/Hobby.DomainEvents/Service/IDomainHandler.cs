using Hobby.DomainEvents.Events;

namespace Hobby.DomainEvents.Service
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        void Handle(T @event);
    }
}
