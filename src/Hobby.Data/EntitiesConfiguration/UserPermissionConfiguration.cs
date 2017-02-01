using Hobby.Entities;

namespace Hobby.Data.EntitiesConfiguration
{
    public class UserPermissionConfiguration : EntityConfigurationBase<UserPermission>
    {
        public UserPermissionConfiguration()
            : base("UserPermissions")
        {
            Property(e => e.IdPermission).IsRequired();
            Property(e => e.IdUser).IsRequired();
        }
    }
}
