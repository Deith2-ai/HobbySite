using Hobby.DomainEvents.Events;
using Hobby.DomainEvents.Service;

namespace Hobby.DomainEvents.Handler
{
    public class EndOfSurveyHandler : IDomainHandler<EndOfSurvey>
    {
        public void Handle(EndOfSurvey args)
        {
            args.Survey.QualityChecker = "Ivan Amalo";
            //Send Email To Ivan to check the survey
        }
    }
}
