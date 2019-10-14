using System;
using System.Collections.Generic;
using System.Text;
using EBBModels.Models;
using ensyte.model.nom;

namespace EBBServices.Interfaces
{
   public interface INominationService
    {

        PackageViewModel GetPackage(string id);

        Response SavePackage (PackageViewModel model);
    }
}
