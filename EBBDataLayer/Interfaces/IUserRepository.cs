using System;
using System.Collections.Generic;
using System.Text;
using EBBEntities.Entities;

namespace EBBDataLayer.Interfaces
{
   public  interface IUserRepository
    {
        ResponseEntity UpdateLoginInfo(LoginEntity entity);
        LoginEntity GetUserByCredentials(string username, string password);
    }
}
