using Hobby.Data.EntitiesConfiguration;
using Hobby.Entities;

namespace Hobby.Data.ConfigurationEntities
{
    public partial class UserConfiguration : EntityConfigurationBase<User>
    {
        public UserConfiguration()
            : base("Users")
        {
            Property(e => e.FirstName).IsRequired();

            Property(e => e.LastName).IsRequired();

            Property(e => e.Email).IsRequired();

            HasMany(e => e.Settings)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdUser)
                .WillCascadeOnDelete(false);

            HasMany(e => e.UserPermissions)
               .WithRequired(e => e.User)
               .HasForeignKey(e => e.IdUser)
               .WillCascadeOnDelete(false);
        }
    }
}
