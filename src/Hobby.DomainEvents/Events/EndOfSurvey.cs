using Hobby.DomainEvents.Domain;

namespace Hobby.DomainEvents.Events
{
    public class EndOfSurvey : IDomainEvent
    {
        public Survey Survey { get; set; }
    }
}
