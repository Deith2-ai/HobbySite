using Hobby.DomainEvents.Events;
using Hobby.DomainEvents.Handler.EmailModel;
using Hobby.DomainEvents.Service;

namespace Hobby.DomainEvents.Handler
{
    public class ActivateEmailNewUserHandler : IDomainHandler<ActivateEmailNewUserEvent>
    {
        //BODY EVENT
        public void Handle(ActivateEmailNewUserEvent @event)
        {
            //must to 
            EmailSettings settings = new EmailSettings();
            EmailOrderProcessor test = new EmailOrderProcessor(settings);
            test.ProcessOrderNewUser(@event.idUser, @event.Email);
        }
    }
}
