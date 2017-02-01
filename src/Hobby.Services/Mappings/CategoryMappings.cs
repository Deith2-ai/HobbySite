using Hobby.DTO;
using Hobby.Entities;

namespace Hobby.Services.Mappings
{
    public static class CategoryMappings
    {
        public static CategoryDTO Map(this Category source)
        {
            var target = new CategoryDTO();

            target.Id = source.Id;
            target.Name = source.Name;

            return target;
        }

        public static Category Map(this CategoryDTO source)
        {
            var target = new Category();

            target.Id = source.Id;
            target.Name = source.Name;

            return target;
        }
    }
}
