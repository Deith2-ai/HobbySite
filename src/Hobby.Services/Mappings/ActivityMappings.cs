using Hobby.DTO;
using Hobby.Entities;

namespace Hobby.Services.Mappings
{
    public static class ActivityMappings
    {
        public static ActivitiesDTO Map(Activities source, ActivitiesDTO target)
        {
            target.ActivityName = source.ActivityName;
            target.Id = source.Id;

            return target;
        }

        public static ActivitiesDTO MapToDTO(this Activities source)
        {
            var target = new ActivitiesDTO();

            return Map(source, target);
        }

        public static Activities Map(ActivitiesDTO source, Activities target)
        {
            target.ActivityName = source.ActivityName;
            target.Id = source.Id;

            return target;
        }
    }
}
