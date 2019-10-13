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
    public class NominationController : ControllerBase
    {
        INominationService _nominationService = new NominationService();

        [HttpGet, Route("GetPackage/{id}")]
        public string GetPackage(string id)
        {
            var obj = _nominationService.GetPackage(id);
            return JsonConvert.SerializeObject(obj, Formatting.None);
        }

        [HttpPost, Route("SavePackage")]
        public string SavePackage([FromBody] PackageViewModel model)
        {
            var obj = _nominationService.SavePackage(model);
            return JsonConvert.SerializeObject(obj, Formatting.None);
        }
    }
}
