using System;
using EBBModels.Models;
using EBBDataServices.Interfaces;
using EBBDataLayer.Interfaces;
using EBBDataLayer.Implementations;
using EBBDataServices.Extensions;

namespace EBBDataServices.Implementations
{
    public class UserSerivce : IUserService
    {
        IUserRepository userRepository = null;
        public LoginViewModel GetUserByCredentials(string username, string password)
        {
            var entity = userRepository.GetUserByCredentials(username, password);
            return entity.ToModel();
        }

       public  Response UpdateLoginInfo(LoginViewModel model)
        {
            var response = model.Validate();
            if (!response.IsSuccess)
            {
                return response;
            }
            var entity = userRepository.UpdateLoginInfo(model.ToEntity());
            return entity.ToModel();
        }
    }

}
