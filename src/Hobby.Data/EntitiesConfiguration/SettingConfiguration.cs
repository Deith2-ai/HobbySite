using Hobby.Entities;

namespace Hobby.Data.EntitiesConfiguration
{
    public partial class SettingConfiguration : EntityConfigurationBase<Setting>
    {
        public SettingConfiguration()
            : base("Settings")
        {
            Property(e => e.Name).IsRequired();
        }
    }
}
