using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EBBModels.Models;
using Newtonsoft.Json;
using EBBDataServices.Implementations;
using EBBDataServices.Interfaces;
namespace EBBWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IUserService userService = new UserSerivce();        
       
        [HttpPost]
        [Route("UpdateLoginInfo")]
        public string UpdateLoginInfo([FromBody] LoginViewModel model)
        {
            var resp = userService.UpdateLoginInfo(model);
            return JsonConvert.SerializeObject(resp, Formatting.None);

        }

        [HttpGet, Route("GetUserByCredentials/{username}/{password}")]
        public string GetUserByCredentials(string username, string password)
        {
            var model = userService.GetUserByCredentials(username, password);
            return JsonConvert.SerializeObject(model, Formatting.None); 
        }     
    }
}
