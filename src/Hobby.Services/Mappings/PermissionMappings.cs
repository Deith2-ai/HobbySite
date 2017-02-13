using Hobby.DTO;
using Hobby.Entities;

namespace Hobby.Services.Mappings
{
    public static class PermissionMappings
    {
        public static PermissionDTO Map(this Permission source)
        {
            var target = new PermissionDTO();

            target.Description = source.Description;
            target.Id = source.Id;
            target.Name = source.Name;
            target.Deleted = source.Deleted;
            target.Value = source.Value;

            return target;
        }

        public static Permission Map(this PermissionDTO source)
        {
            var target = new Permission();

            target.Description = source.Description;
            target.Id = source.Id;
            target.Name = source.Name;
            target.Deleted = source.Deleted;
            target.Value = source.Value;

            return target;
        }
    }
}
