using Hobby.DomainEvents.Events;

namespace Hobby.DomainEvents.Service
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}
