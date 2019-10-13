using System;
using EBBEntities.Entities;
using EBBModels.Models;

namespace EBBDataServices.Interfaces
{
    public interface IUserService
    {
        Response UpdateLoginInfo(LoginViewModel model);
        LoginViewModel GetUserByCredentials(string username, string password);
    }
}
