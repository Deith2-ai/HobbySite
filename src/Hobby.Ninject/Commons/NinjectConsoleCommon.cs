using Hobby.Ninject.Containers;
using Ninject;

namespace Hobby.Ninject.Commons
{
    public class NinjectConsoleCommon
    {
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        public static IKernel Instance()
        {
            var kernel = new StandardKernel();
            try
            {
                NinjectConsoleContainer.Container(kernel);

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

    }
}
