using System;
using System.Collections.Generic;
using System.Text;
using EBBDataServices.Interfaces;
using EBBModels.Models;
using EBBDataLayer.Interfaces;
using EBBEntities.Entities;
using EBBDataLayer.Implementations;
using EBBDataServices.Extensions;
using System.Linq;
using ensyte.model.nom;

namespace EBBDataServices.Implementations
{
    public class NominationService : INominationService
    {
        private INominationRepository _nominationRepository => new NominationRepositoryEntityFramework();

        public Response SavePackage(PackageViewModel model)
        {
            var entity = _nominationRepository.GetPackage(model.ID);
            entity.BusAssociate.NAME = model.BusinessAssociateName;
            entity.COMMENTS = model.COMMENTS;
            var respEntity = _nominationRepository.SavePackage(entity);
            return new Response() { IsSuccess = respEntity.IsSuccess, ErrorMessages = respEntity.ErrorMessages };
        }
        public PackageViewModel GetPackage(string id)
        {
            var pkg = new PackageViewModel();
            var entity = _nominationRepository.GetPackage(id);
            pkg.BusinessAssociateName = entity.BusinessAssociateName;
            pkg.COMMENTS = entity.COMMENTS;
            pkg.ID = id;
            return pkg;
        }
    }
}
