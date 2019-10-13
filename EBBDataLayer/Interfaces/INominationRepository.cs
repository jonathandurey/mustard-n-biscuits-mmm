using System;
using System.Collections.Generic;
using System.Text;
using EBBEntities.Entities;
using ensyte.model.nom;
namespace EBBDataLayer.Interfaces
{
   public interface INominationRepository
    {
        IList<NominationEntity> GetListByStartDate(DateTime startDate);

        ResponseEntity SavePackage(Package pkg);
        Package GetPackage(string id);
        IList<InvoiceSummaryDataContractEntity> GetInvoiceSummaryListFromDB(
            string buId, string baId, DateTime gasFlowMonth, string contractType, string cntrNum, string zone);
    }
}
