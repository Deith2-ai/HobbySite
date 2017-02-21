using Hobby.Data.EntitiesConfiguration;
using Hobby.Entities;

namespace Hobby.Data.EntitiesConfiguration
{
    public partial class ActivitiesConfiguration : EntityConfigurationBase<Activities>
    {
        public ActivitiesConfiguration() 
            : base("Activities")
        {
            Property(e => e.ActivityName).IsRequired();            
        }
    }
}
