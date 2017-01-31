using Hobby.Entities;

namespace Hobby.Data.EntitiesConfiguration
{
    public partial class CategorieConfiguration : EntityConfigurationBase<Category>
    {
        public CategorieConfiguration()
            : base("Categories")
        {
            Property(e => e.Name).IsRequired();
        }
    }
}
