using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace EBBModels.Models
{
    public class MvcCodeValues
    {
        public List<SelectListItem> GetCodeValuesForMvcPools(string str1, string str2, string str3)
        {
            return new List<SelectListItem>();
        }

        public List<SelectListItem> GetCodeValuesForMvc(string str1, string str2)
        {
            return new List<SelectListItem>();
        }

        public List<SelectListItem> GetStaticCodeValuesForDropDown(string name)
            {
            return new List<SelectListItem>();
            }
    }
}
