using System;
using System.Collections.Generic;
using System.Text;
using EBBModels.Models;
using EBBEntities.Entities;

namespace EBBDataServices.Extensions
{
    public static class Extensions
    {
        public static LoginViewModel ToModel(this LoginEntity entity)
        {
            return new LoginViewModel()
            {
                UserName = entity.UserName,
                Password = entity.Password,
                ErrorMessages = entity.ErrorMessages
            };
        }
        public static LoginEntity ToEntity(this LoginViewModel model)
        {
            return new LoginEntity()
            {
                UserName = model.UserName,
                Password = model.Password,
                ErrorMessages = model.ErrorMessages
            };
        }
        public static Response ToModel(this ResponseEntity entity)
        {
            return new Response()
            {
                IsSuccess = entity.IsSuccess,
                ErrorMessages = entity.ErrorMessages
            };
        }
        public static ResponseEntity ToEntity(this Response model)
        {
            return new ResponseEntity()
            {
                IsSuccess = model.IsSuccess,
                ErrorMessages = model.ErrorMessages
            };
        }

        public static PackageViewModel ToModel(this ensyte.model.nom.Package pkg)
        {
            //copy all the properties.
            return new PackageViewModel()
            {
                BusinessAssociateName = pkg.BusAssociate.NAME,
                COMMENTS = pkg.COMMENTS
            };
        }
    }
}
