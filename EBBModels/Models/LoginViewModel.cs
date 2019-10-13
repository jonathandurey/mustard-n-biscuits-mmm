using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBModels.Models
{
    public class LoginViewModel : BaseViewModel
    {
        public override Response Validate()
        {
            var resp = new Response() { IsSuccess = true };
            if (string.IsNullOrEmpty(UserName))
            {
                resp.IsSuccess = false;
                resp.ErrorMessages.Add("Username is required");
            }
            if (string.IsNullOrEmpty(Password))
            {
                resp.IsSuccess = false;
                resp.ErrorMessages.Add("Password is required");
            }
            return resp;
        }
        public string UserName { get; set; }

        public bool IsAuthenticated { get; set; }
        public string Password { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public bool HasLocalPassword { get; set; }
        public LoginViewModel() : base()
        {

        }
    }
}
