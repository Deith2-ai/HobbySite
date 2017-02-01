using Hobby.Data;
using Hobby.Data.Interface;
using Hobby.Services;
using Hobby.Services.Interfaces;
using Ninject;

namespace Hobby.Ninject.Containers
{
    public class NinjectConsoleContainer
    {
        public static void Container(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InThreadScope();
            kernel.Bind<IUserService>().To<UserService>();
        }
    }
}
