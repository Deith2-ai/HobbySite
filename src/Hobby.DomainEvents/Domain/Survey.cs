using Hobby.DomainEvents.Events;
using System;

namespace Hobby.DomainEvents.Domain
{
    public class Survey
    {
        public Guid Id { get; private set; }

        public DateTime EndTime { get; private set; }

        public string QualityChecker { get; set; }

        public Survey()
        {
            this.Id = Guid.NewGuid();
        }

        public void EndSurvey()
        {
            EndTime = DateTime.Now;
            DomainEvent.Raise(new EndOfSurvey() { Survey = this });
        }
    }
}
