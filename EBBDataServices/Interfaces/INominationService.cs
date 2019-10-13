using System;
using System.Collections.Generic;
using System.Text;
using EBBModels.Models;
using EBBEntities.Entities;
using ensyte.model.nom;

namespace EBBDataServices.Interfaces
{
    public interface INominationService
    {
        PackageViewModel GetPackage(string id);

        Response SavePackage(PackageViewModel model);
    }
}
