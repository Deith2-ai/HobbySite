using Hobby.Common.Authentication;
using Hobby.Data.Interface;
using Hobby.DTO;
using Hobby.Entities;
using Hobby.Services.Mappings;
using Hobby.UnitTests.TestingTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace Hobby.UnitTests.IOC.Ninject
{
    [TestsOwner("dlukasik")]
    [TestClass]
    public class NinjectFirstTests
    {
        [TestMethod]
        public void NinjectFirstMethod()
        {
            var uow = IoCNinjectProvider.Instance.Get<IUnitOfWork>();

            var user = new UserDTO
            {
                Email = "czarnuch1001@gmail.com",
                FirstName = "darek4",
                LastName = "darek4",
                Password = "2"
            };

            user.Password = user.Password.getSHA1();
            var entity = user.Map();
            uow.Users.Add(entity);
            uow.Save();

            Assert.IsNotNull(entity.Id);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var uow = IoCNinjectProvider.Instance.Get<IUnitOfWork>();
            var entity = new Permission
            {
                Name = "Admin",
                Value = 1,
                Description = "aaaa"
            };

            uow.Permissions.Add(entity);
            uow.Save();
        }
    }
}
