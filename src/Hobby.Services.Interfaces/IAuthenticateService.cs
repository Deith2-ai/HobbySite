using Hobby.DTO;
using System.Collections.Generic;

namespace Hobby.Services.Interfaces
{
    public interface IAuthenticateService
    {
        UserDTO CheckUser(string login, string password);

        List<string> PermissionActiveNameList(decimal idUser);

        bool Register(UserDTO user);
    }
} 