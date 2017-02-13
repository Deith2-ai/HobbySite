using Hobby.Entities;
using System.Collections.Generic;
using Hobby.DTO;

namespace Hobby.Services.Mappings
{
    public static class UserMappings
    {
        public static User Map(this UserDTO source)
        {
            User target = new User();

            target.Id = source.Id;
            target.FirstName = source.FirstName;
            target.LastName = source.LastName;
            target.Password = source.Password;
            target.Email = source.Email;
            target.City = source.City;
            target.Avatar = source.Avatar;

            return target;
        }

        public static UserDTO Map(this User source)
        {
            UserDTO target = new UserDTO();
            target.Id = source.Id;
            target.FirstName = source.FirstName;
            target.LastName = source.LastName;
            target.Password = source.Password;
            target.Email = source.Email;
            target.Avatar = source.Avatar;
            target.City = source.City;

            return target;
        }

        public static List<UserDTO> MapList(this List<User> source)
        {
            var list = new List<UserDTO>();
            foreach (var item in source)
            {
                list.Add(item.Map());
            }

            return list;
        }
    }
}
