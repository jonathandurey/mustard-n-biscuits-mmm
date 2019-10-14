using System;
using System.Collections.Generic;
using System.Text;
using EBBModels.Models;
using EBBServices.Interfaces;
using ensyte.model.nom;

namespace EBBServices.Implementations
{
    public class NominationService : BaseService ,INominationService
    {

        public Response SavePackage(PackageViewModel model)
        {
            var url = @"Nomination/SavePackage";
            return Post(url,model);
        }
        public PackageViewModel GetPackage(string id)
        {
            var url = @"Nomination/GetPackage/" + id;
            return Get<PackageViewModel>(url);
        }
  
    }
}
