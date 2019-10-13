using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using EBBDataLayer.Interfaces;
using EBBEntities.Entities;
using ensyte.model.nom;
using ensyte.process.Util;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord;
using ensyte.model.ba;
using ensyte.model.pipeline;
using ensyte.model.contracts;
using ensyte.model.common;
using ensyte.model.accounting;
using ensyte.model.security;
using ensyte.model.caprel.offers;
using ensyte.model.caprel.awards;
using ensyte.model.caprel.bids;
using ensyte.model.caprel.recalls;
using ensyte.model.infopostings.notices;
using ensyte.model.infopostings.IOC;
using ensyte.model.flowinggas;
using Castle.Windsor.Configuration;
using Castle.Windsor.Proxy;
using System.Collections;
using System.Reflection;

namespace EBBDataLayer.Implementations
{


    public class NominationRepositoryEntityFramework : INominationRepository
    {
        
        //private Type sqlCommandSet = Assembly.Load("System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089").GetType("System.Data.SqlClient.SqlCommandSet");
        private List<Type> GetAllTypes()
        {
            var lst = new List<Type>();
            lst.Add(typeof(BusinessAssociate));
            lst.Add(typeof(BARole));
            lst.Add(typeof(BAAddress));
            lst.Add(typeof(Codes));
            lst.Add(typeof(Sequences));
            lst.Add(typeof(Country));
            lst.Add(typeof(State));
            lst.Add(typeof(City));
            lst.Add(typeof(County));
            lst.Add(typeof(BANote));
            lst.Add(typeof(BACrossReference));
            lst.Add(typeof(BAContact));
            lst.Add(typeof(BAContactRole));
            lst.Add(typeof(BADocument));
            lst.Add(typeof(BAContactTele));
            lst.Add(typeof(BusinessAssociateDefaults));
            lst.Add(typeof(BAContactComm));
            lst.Add(typeof(PaymentTerm));
            lst.Add(typeof(Division));
            lst.Add(typeof(DecisionUnit));
            lst.Add(typeof(WellZone));
            lst.Add(typeof(CodesMaster));
            lst.Add(typeof(CodesModule));
            lst.Add(typeof(BAAgreement));
            lst.Add(typeof(AgreementLpXref));
            lst.Add(typeof(CodesRule));
            lst.Add(typeof(BACreditLimit));
            lst.Add(typeof(ContractCreditLimit));
            lst.Add(typeof(ContactNotification));
            lst.Add(typeof(Season));
            lst.Add(typeof(RateCode));
            lst.Add(typeof(Contract));
            lst.Add(typeof(ContractStatus));
            lst.Add(typeof(ContractCrossReference));
            lst.Add(typeof(Amendment));
            lst.Add(typeof(ContractComment));
            lst.Add(typeof(ContractDemand));
            lst.Add(typeof(ContractPathRate));
            lst.Add(typeof(ContractQuantity));
            lst.Add(typeof(Rate));
            lst.Add(typeof(ErrorLog));
            lst.Add(typeof(Variable));
            lst.Add(typeof(PriceReferenceIndex));
            lst.Add(typeof(PriceArea));
            lst.Add(typeof(PriceAreaDetail));
            lst.Add(typeof(ContractMeterAssign));
            lst.Add(typeof(ContractScanData));
            lst.Add(typeof(StorageRatchet));
            lst.Add(typeof(StorageRatchetDetail));
            lst.Add(typeof(ContractWhSettlement));
            lst.Add(typeof(ContractWHStl));
            lst.Add(typeof(ContractWhStlChgDtl));
            lst.Add(typeof(MatrixHdr));
            lst.Add(typeof(AcaRate));
            lst.Add(typeof(MatrixStartPtDtl));
            lst.Add(typeof(MatrixEndPtDtl));
            lst.Add(typeof(Alert));
            lst.Add(typeof(ContractChargeDef));
            lst.Add(typeof(ContractNonPathQuantity));
            lst.Add(typeof(AgentAssign));
            lst.Add(typeof(ImBalGroup));
            lst.Add(typeof(ImBalGrpDef));
            lst.Add(typeof(Weather));
            lst.Add(typeof(CntrAllocPf));
            lst.Add(typeof(ContractQuanitySeason));
            lst.Add(typeof(ContractSegQty));
            lst.Add(typeof(ContractSegNetQty));
            lst.Add(typeof(FuturePrice));
            lst.Add(typeof(FuturePriceDetail));
            lst.Add(typeof(BidPackageDetail));
            lst.Add(typeof(StorageRatchetInfo));
            lst.Add(typeof(GasMeterCdpAlloc));
            lst.Add(typeof(GasMeterCdpAllocDtl));
            lst.Add(typeof(StorageRatchetStatus));
            lst.Add(typeof(Point));
            lst.Add(typeof(Pipeline));
            lst.Add(typeof(Zone));
            lst.Add(typeof(SiteFacility));
            lst.Add(typeof(SiteFacilityServices));
            lst.Add(typeof(Region));
            lst.Add(typeof(PointCrossReference));
            lst.Add(typeof(RegionFactor));
            lst.Add(typeof(MeterPointDocument));
            lst.Add(typeof(NonOrificeDevice));
            lst.Add(typeof(NonOrificMeter));
            lst.Add(typeof(InfoService));
            lst.Add(typeof(MeasurementPoint));
            lst.Add(typeof(MeasurePointNote));
            lst.Add(typeof(GaPointShipper));
            lst.Add(typeof(MeasurementPointScanData));
            lst.Add(typeof(Well));
            lst.Add(typeof(SamplePoint));
            lst.Add(typeof(SamplePointMeterXref));
            lst.Add(typeof(SampleAnalysisHeader));
            lst.Add(typeof(Facility));
            lst.Add(typeof(GasMeter));
            lst.Add(typeof(GasMeterHistory));
            lst.Add(typeof(SuppliedVolume));
            lst.Add(typeof(AllocationNetwork));
            lst.Add(typeof(AllocationNetworkStatus));
            lst.Add(typeof(AllocationProcess));
            lst.Add(typeof(MeasurementPointProcess));
            lst.Add(typeof(ProcessProcess));
            lst.Add(typeof(SuppliedVolumeErrorLog));
            lst.Add(typeof(MeasurementPointVolume));
            lst.Add(typeof(MeasurementPtFormulae));
            lst.Add(typeof(SuppliedVolumePpa));
            lst.Add(typeof(WhGaApproval));
            lst.Add(typeof(P1Target));
            lst.Add(typeof(RegionHeatVCorrFactor));
            lst.Add(typeof(PseudoMeter));
            lst.Add(typeof(SiteFacilityCis));
            lst.Add(typeof(SiteFacilityCustomerCis));
            lst.Add(typeof(SiteFacilityServicesCis));
            lst.Add(typeof(MeasurementPointInfo));
            lst.Add(typeof(MeasurementPointDQ));
            lst.Add(typeof(WorkDayControl));
            lst.Add(typeof(PointMarketPoolChoice));
            lst.Add(typeof(SiteFacilityCisCapAlloc));
            lst.Add(typeof(EnvGasmeterCum));
            lst.Add(typeof(DemandStats));
            lst.Add(typeof(MeasurementCyclePointVolume));
            lst.Add(typeof(GasDayTargetDtl));
            lst.Add(typeof(GasDayTarget));
            lst.Add(typeof(DemandStatDefault));
            lst.Add(typeof(MeasPtCycleVolumeDay));
            lst.Add(typeof(GLAccount));
            lst.Add(typeof(GLMainType));
            lst.Add(typeof(GLSubType));
            lst.Add(typeof(GLAccountLinkerXref));
            lst.Add(typeof(GLStatement));
            lst.Add(typeof(GLAccountProject));
            lst.Add(typeof(ContractMonthlyStatement));
            lst.Add(typeof(MonthlyStatement));
            lst.Add(typeof(GLStatementPriceVolume));
            lst.Add(typeof(GLStatementPriceVolumeDaily));
            lst.Add(typeof(GLAccountFinancialGastar));
            lst.Add(typeof(GLAccountFinancialGastarContract));
            lst.Add(typeof(GLAccountGastrXrefSPDetail));
            lst.Add(typeof(GLAccountGastrXrefSPPGC));
            lst.Add(typeof(GLAccountGastrXrefSP));
            lst.Add(typeof(GLAccountFinancialInterface));
            lst.Add(typeof(GLAccountFinancialInterfaceDetails));
            lst.Add(typeof(GLAccountFinancial));
            lst.Add(typeof(GLAccountFinancialGastarBA));
            lst.Add(typeof(VendorInvoice));
            lst.Add(typeof(GLAccountFinancialBalance));
            lst.Add(typeof(GLAccountFinancialEntrry));
            lst.Add(typeof(Invoice));
            lst.Add(typeof(InvoiceDetail));
            lst.Add(typeof(InvoiceAddress));
            lst.Add(typeof(Expense));
            lst.Add(typeof(ExpenseAddress));
            lst.Add(typeof(ExpenseDetail));
            lst.Add(typeof(VendorInvoiceScanData));
            lst.Add(typeof(VendorInvoiceStatus));
            lst.Add(typeof(GLAccountAllocation));
            lst.Add(typeof(GLAccountAllocationPct));
            lst.Add(typeof(GLAccountFinancialGastarHDR));
            lst.Add(typeof(VendorContract));
            lst.Add(typeof(VendorStatementDetail));
            lst.Add(typeof(VendorContractCharge));
            lst.Add(typeof(ManualJEDocument));
            lst.Add(typeof(Formulas));
            lst.Add(typeof(WorksheetApproval));
            lst.Add(typeof(GLAccountFinancialGastarAct));
            lst.Add(typeof(GLAccountFinancialGastarBAAct));
            lst.Add(typeof(GLAccountFinancialGastarContractAct));
            lst.Add(typeof(GLAccountFinancialGastarHDRAct));
            lst.Add(typeof(GLAccountFinancialInterfaceAct));
            lst.Add(typeof(GLAccountFinancialInterfaceDetailAct));
            lst.Add(typeof(GLStatementAcr));
            lst.Add(typeof(MonthlyStatementAcr));
            lst.Add(typeof(VendorInvoiceAdjustment));
            lst.Add(typeof(VendorInvoiceAddress));
            lst.Add(typeof(ContactSecurityRole));
            lst.Add(typeof(UserLoginInfo));
            lst.Add(typeof(UserSecurityScope));
            lst.Add(typeof(RoleSecurity));
            lst.Add(typeof(EbbUserLogin));
            lst.Add(typeof(DbaRole));
            lst.Add(typeof(SessionRole));
            lst.Add(typeof(SecurityPermission));
            lst.Add(typeof(SecurityRolePermission));
            lst.Add(typeof(Package));
            lst.Add(typeof(PackagePath));
            lst.Add(typeof(PackagePathDetail));
            lst.Add(typeof(PackageVolumeDetail));
            lst.Add(typeof(Activity));
            lst.Add(typeof(BidPackage));
            lst.Add(typeof(BuySell));
            lst.Add(typeof(Route));
            lst.Add(typeof(RouteSegment));
            lst.Add(typeof(BidPackageForReport));
            lst.Add(typeof(BuySellDeal));
            lst.Add(typeof(BuySellRoute));
            lst.Add(typeof(MarketerPoolSummary));
            lst.Add(typeof(RateType));
            lst.Add(typeof(RateDetail));
            lst.Add(typeof(PointMarketPoolAct));
            lst.Add(typeof(PointMarketPoolGpp));
            lst.Add(typeof(MarketerPoolSummaryDetail));
            lst.Add(typeof(PackageImbalTrade));
            lst.Add(typeof(BidConfirm));
            lst.Add(typeof(ActivityDetailNonPathPackage));
            lst.Add(typeof(NonPathPackage));
            lst.Add(typeof(PointBalance));
            lst.Add(typeof(PointBalanceRdSum));
            lst.Add(typeof(P1CapacityRequirement));
            lst.Add(typeof(P1TargetDetail));
            lst.Add(typeof(P1CapacityRequirementDRN));
            lst.Add(typeof(P1CapacityRequirementDIV));
            lst.Add(typeof(P1CapacityRequirementDec));
            lst.Add(typeof(PDAAlloc));
            lst.Add(typeof(PDAAllocDtl));
            lst.Add(typeof(P1CapacityReqPerContract));
            lst.Add(typeof(GasMeterSch));
            lst.Add(typeof(PackageVolumeDtlHistory));
            lst.Add(typeof(PackagePathHistory));
            lst.Add(typeof(PointMarketPoolIg));
            lst.Add(typeof(P1TargetForecast));
            lst.Add(typeof(P1CapacityReqPerPoolForecast));
            lst.Add(typeof(PointMarketPoolInvIgDetail));
            lst.Add(typeof(PointMarketPoolImbalTrade));
            lst.Add(typeof(PointMarketPoolImbalTradeDetail));
            lst.Add(typeof(SiteFacilityCisTierAlloc));
            lst.Add(typeof(SiteFacilityCisTierDtl));
            lst.Add(typeof(SiteFacilityCisTierDeliveryDtl));
            lst.Add(typeof(HddWeatherInput));
            lst.Add(typeof(CapInputDetail));
            lst.Add(typeof(CapInputHdr));
            lst.Add(typeof(BuyStorage));
            lst.Add(typeof(BuyStorageRoute));
            lst.Add(typeof(BuyStorageDeal));
            lst.Add(typeof(LngSale));
            lst.Add(typeof(LngSaleWgt));
            lst.Add(typeof(LngSaleMtr));
            lst.Add(typeof(Unit));
            lst.Add(typeof(EBBMessage));
            lst.Add(typeof(EbbDocument));
            lst.Add(typeof(UploadDocument));
            lst.Add(typeof(BidPath));
            lst.Add(typeof(BidPathDetail));
            lst.Add(typeof(BidStatusHist));
            lst.Add(typeof(EnvProducerMeter));
            lst.Add(typeof(MeasurementPtParticFormulae));
            lst.Add(typeof(MeasurementPtPartic));
            lst.Add(typeof(BidPackageHistory));
            lst.Add(typeof(BidVolumeDetail));
            lst.Add(typeof(PipelineNotice));
            lst.Add(typeof(CapRelOffer));
            lst.Add(typeof(CapRelBid));
            lst.Add(typeof(CapRelComment));
            lst.Add(typeof(CapRelBidNonPath));
            lst.Add(typeof(CapRelAward));
            lst.Add(typeof(CapRelError));
            lst.Add(typeof(CapRelRecall));
            lst.Add(typeof(InfoPostingNotice));
            lst.Add(typeof(InfoPostingNoticeRecp));
            lst.Add(typeof(CapRelRecallLocQty));
            lst.Add(typeof(IocFootNote));
            lst.Add(typeof(IocCustomers));
            lst.Add(typeof(BatchJob));
            lst.Add(typeof(BatchJobLog));
            lst.Add(typeof(EmailHistory));
            lst.Add(typeof(ContractPathRateException));
            lst.Add(typeof(DivisionToDecUnit));
            lst.Add(typeof(MarketerPoolInvoice));
            lst.Add(typeof(MarketerPoolInvDetail));
            lst.Add(typeof(MarketerPoolInvFormula));
            lst.Add(typeof(MarketerPoolFormula));
            lst.Add(typeof(ContractNetQty));
            lst.Add(typeof(CprRsCode));
            lst.Add(typeof(RatePathOverrideDtl));
            lst.Add(typeof(PointBalanceFifo));
            lst.Add(typeof(PointBalanceAdj));
            lst.Add(typeof(PointBalanceLiqSt));
            lst.Add(typeof(ContractAsset));
            lst.Add(typeof(ContractAssetFee));
            lst.Add(typeof(PtWacogBal));
            lst.Add(typeof(PumperRoute));
            lst.Add(typeof(PointMarketPoolIGDetail));
            lst.Add(typeof(MeasurementPointVolumeHistory));
            lst.Add(typeof(PTImbalance));
            lst.Add(typeof(ExcessInjandWd));
            lst.Add(typeof(PlShSummary));
            lst.Add(typeof(PlCntrSummary));
            lst.Add(typeof(PlMeasSummary));
            lst.Add(typeof(PlCntrPtSummary));
            lst.Add(typeof(WeatherGasDay));
            lst.Add(typeof(WeatherGasDayM));
            lst.Add(typeof(CustomerStat));
            lst.Add(typeof(GasDayGasPlan));
            lst.Add(typeof(PointMarketPoolChoiceDtl));
            lst.Add(typeof(DemandStatSummary));
            lst.Add(typeof(GasDayTargetOvr));
            lst.Add(typeof(LNGSalePriceReference));
            lst.Add(typeof(PointMarketPoolChoiceMovol));
            lst.Add(typeof(BAEnroll));
            lst.Add(typeof(BAPremiseEnroll));
            lst.Add(typeof(DailyImbalanceTolerance));
            lst.Add(typeof(DailyImbalanceToleranceDtl));
            lst.Add(typeof(BAEdiSetup));
            lst.Add(typeof(SiteFacsCisMtr));
            return lst;
        }
        private void PerformActiveRecordInitialization<T>()
        {
            ActiveRecordStarter.ResetInitializationFlag();
            var src = new Castle.ActiveRecord.Framework.Config.InPlaceConfigurationSource();
            var properties = new Dictionary<string, string>();

            //     < add key = "hibernate.connection.provider" value = "NHibernate.Connection.DriverConnectionProvider" />
            properties.Add("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
            properties.Add("dialect", "NHibernate.Dialect.MsSql2008Dialect");
            properties.Add("connection.provider", "NHibernate.Connection.DriverConnectionProvider");         
            properties.Add("proxyfactory.factory_class", "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle");
            properties.Add("connection.connection_string", "UID=felix;Password=rollhide;Initial Catalog=ENSRC020419DEVAD17;Data Source=172.21.5.3,1435");
            properties.Add("show_sql", "true");
            properties.Add("query.startup_check", "false");
            src.Add(typeof(ActiveRecordBase), properties);

            Type[] types = GetAllTypes().ToArray();
      
            ActiveRecordStarter.Initialize(src, types);
 
           // var itm = src.GetConfiguration(typeof(ActiveRecordBase));
        }

        public IList<NominationEntity> GetListByStartDate(DateTime startDate)
        {
            return new List<NominationEntity>();
        }

        public ResponseEntity SavePackage(Package pkg)
        {
            var resp = new ResponseEntity() { IsSuccess = true, ErrorMessages = new List<string>() };
            PerformActiveRecordInitialization<Package>();
            try
            {
                pkg.SaveAndFlush();
            }
            catch ( Exception ex)
            {
                resp.ErrorMessages.Add(ex.Message);
                resp.IsSuccess = false;
            }
            return resp;
        }
        public Package GetPackage(string id)
        {
            PerformActiveRecordInitialization<Package>();
            var pkg = Package.GetByPrimaryKey(id);
            return pkg;
        }

        public IList<InvoiceSummaryDataContractEntity> GetInvoiceSummaryListFromDB(string buId, string baId, DateTime gasFlowMonth, string contractType, string cntrNum, string zone)
        {
            //DataSet1.ENT_INV_DTLDataTable tbl = new DataSet1.ENT_INV_DTLDataTable();
            //  var test = tbl.FindByINV_DTL_NUM("0000000100001");


            var returnList = new List<InvoiceSummaryDataContractEntity>();
            for (int i = 0; i < 10; i++)
            {
                returnList.Add(new InvoiceSummaryDataContractEntity()
                {
                    MARKETER = "MARKETER" + i.ToString(),
                    LDC = "LDC" + i.ToString(),
                    CNTR_TITLE = "CNTR_TITLE" + i.ToString(),
                    ACCT_MONTH = "ACCT_MONTH" + i.ToString(),
                    CHG_CD = "CHG_CD" + i.ToString(),
                    DESCRIPTION = "DESCRIPTION" + i.ToString(),
                    CPR_DLV_PT_NUM = "CPR_DLV_PT_NUM" + i.ToString(),
                    ACT_ALT_NUM = "ACT_ALT_NUM" + i.ToString(),
                    DLV_PT_NUM = "DLV_PT_NUM" + i.ToString(),
                    ZONE_PT_NUM = "ZONE_PT_NUM" + i.ToString(),
                    ZONE_NAME = "ZONE_NAME" + i.ToString(),
                    ENERGY = i,
                    UNIT_MEAS = i.ToString(),
                    PRICE = i,
                    COST = i,
                    ADJ = i,
                    STMT = "STMT" + i.ToString(),
                    DATESTAMP = "DATESTAMP" + i.ToString(),
                    USERSTAMP = "USERSTAMP" + i.ToString(),
                    PATH_NUM = "PATH_NUM" + i.ToString(),
                    DLV_ZONE_ID = "DLV_ZONE_ID" + i.ToString(),
                    RCV_ZONE_ID = "RCV_ZONE_ID" + i.ToString(),
                    CNTR_NUM = "CNTR_NUM" + i.ToString(),
                    CNTR_PATH_RATE_NUM = "CNTR_PATH_RATE_NUM" + i.ToString()
                });
            }
            return returnList;
        }
    }
}
