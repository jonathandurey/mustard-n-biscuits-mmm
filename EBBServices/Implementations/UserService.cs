using System;
using System.Net.Http;
using EBBServices.Interfaces;
using EBBModels.Models;
using Newtonsoft.Json;

namespace EBBServices.Implementations
{
    public class UserSerivce : BaseService, IUserService
    {
        public LoginViewModel GetUserByCredentials(string username, string password)
        {
            var url = @"Home/GetUserByCredentials/" + username + "/" + password;
            return Get<LoginViewModel>(url);
        }

        public Response UpdateLoginInfo(LoginViewModel model)
        {
            var url = @"Home/UpdateLoginInfo/";
           var result = Post<LoginViewModel>(url, model);
            return result;
        }
    }
}
