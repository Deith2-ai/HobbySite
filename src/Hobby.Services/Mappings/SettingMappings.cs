using Hobby.DTO;
using Hobby.Entities;

namespace Hobby.Services.Mappings
{
    public static class SettingMappings
    {
        public static Setting Map(this SettingDTO source)
        {
            Setting target = new Setting();

            target.Id = source.Id;
            target.IdUser = source.IdUser;
            target.Name = source.Name;
            target.Value = source.Value;

            return target;
        }

        public static SettingDTO Map(this Setting source)
        {
            SettingDTO target = new SettingDTO();

            target.Id = source.Id;
            target.IdUser = source.IdUser;
            target.Name = source.Name;
            target.Value = source.Value;

            return target;
        } 
    }
}
