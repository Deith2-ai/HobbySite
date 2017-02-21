using Hobby.Entities;
using System;
using System.Data.Entity;

namespace Hobby.Data
{
    public class ModelDBInitializer : DropCreateDatabaseAlways<HobbyDbContext>
    {
        protected override void Seed(HobbyDbContext context)
        {
            var defaultUser = new User
            {
                Email = "test@test.pl",
                FirstName = "FirstNameFirstUser",
                LastName = "LastNameFirstUser",
                Password = "test1",
            };

            var defaultPermision = new Permission
            {
                Name = "Admin",
                Description = "Admin permission",
                Value = 1
            };

            var defaultCategorie = new Category
            {
                Name = "Category 1"
            };

            var defaultSetting = new Setting
            {
                Name = "settings 1",
                Value = true,
                User = defaultUser,
                IdUser = defaultUser.Id
            };

            var defaultUserPermision = new UserPermission
            {
                IdUser = defaultUser.Id,
                IdPermission = defaultPermision.Id,
                User = defaultUser,
                Permission = defaultPermision                
            };

            context.Set<User>().Add(defaultUser);
            context.Set<Permission>().Add(defaultPermision);
            context.Set<Category>().Add(defaultCategorie);
            context.Set<Setting>().Add(defaultSetting);
            context.Set<UserPermission>().Add(defaultUserPermision);

            base.Seed(context);
        }
    }
}
