using Hobby.Data;
using Hobby.Data.Interface;
using Hobby.DomainEvents;
using Hobby.DomainEvents.Events;
using Hobby.DomainEvents.Handler;
using Hobby.DomainEvents.Service;
using Hobby.Services;
using Hobby.Services.Interfaces;
using Ninject;

namespace Hobby.Ninject.Containers
{
    public class NinjectWebContainer
    {
        public static void Container(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InThreadScope();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IAuthenticateService>().To<AuthenticationService>();
            kernel.Bind<IActivitiesService>().To<ActivitiesService>();

            DomainEvent.Dispatcher = new NinjectEventContainer(kernel);
            kernel.Bind<IDomainHandler<EndOfSurvey>>().To<EndOfSurveyHandler>();
            kernel.Bind<IDomainHandler<ActivateEmailNewUserEvent>>().To<ActivateEmailNewUserHandler>();
        }
    }
}
