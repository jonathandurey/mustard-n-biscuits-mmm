using System;
using EBBModels.Models;

namespace EBBServices.Interfaces
{
    public interface IUserService
    {
        Response UpdateLoginInfo(LoginViewModel model);
        LoginViewModel GetUserByCredentials(string username, string password);
    }
}
