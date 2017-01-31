using Hobby.Entities;

namespace Hobby.Data.EntitiesConfiguration
{
    public partial class PermissionConfiguration : EntityConfigurationBase<Permission>
    {
        public PermissionConfiguration()
            : base("Permissions")
        {
            Property(e => e.Name).IsRequired();
            Property(e => e.Deleted).IsRequired();

            HasMany(e => e.UserPermissions)
               .WithRequired(e => e.Permission)
               .HasForeignKey(e => e.IdPermission)
               .WillCascadeOnDelete(false);
        }
    }
}
