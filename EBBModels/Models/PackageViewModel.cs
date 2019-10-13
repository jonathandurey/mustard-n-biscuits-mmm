using System;
using System.Collections.Generic;
using System.Text;

namespace EBBModels.Models
{
    public class PackageViewModel : BaseViewModel
    {
        public PackageViewModel()
        {

        }
        public override Response Validate()
        {
        return  new Response() { IsSuccess = true };
        }

        public string COMMENTS { get; set; }
        public string ID { get; set; }
        public string BusinessAssociateName { get; set; }
        public string StartDateString { get; set; }
        public string EndDateString { get; set; }
        public string DateStampString { get; set; }
        public string VolumeTypeDescription { get; set; }
        public string INTER_SHIPPER_BANAME { get; set; }
        public string INTERSHIPPERNAME { get; set; }
        public double NOM_DLV_VOL { get; set; }
        public double CUM_COST_Daily { get; }
        public string RATE_TYPE { get; }
        public double NOM_Daily_DLV_VOL { get; set; }
        public double NOM_Daily_DLV_VOL_EVR { get; set; }
        public double NOM_OFF_Daily_DLV_VOL { get; }
        public double CUMULATIVE_NOM_Daily_Amount { get; }
        public double CUMULATIVE_ACT_Daily_Amount { get; }
        public double CUMULATIVE_NOM_Daily_DLV_VOL { get; }
        public double CUMULATIVE_ACT_Daily_DLV_VOL { get; set; }
        public double CUMULATIVE_ACT_Daily_RCV_VOL { get; set; }
        public double PriceCalculated { get; }
        public double PriceCalculated_ACT { get; }
        public double CUMULATIVE_OFF_NOM_Daily_DLV_VOL { get; }
        public double NOM_Daily_RCV_VOL_DURATION { get; set; }
        public double CONFIRM_RCV_VOL_DURATION { get; set; }
        public double ACT_RCV_VOL_DURATION { get; set; }
        public double NOM_Daily_RCV_VOL { get; set; }
        public double NOM_Daily_RCV_VOL_EVR { get; set; }
        public string SupplierBaName { get; set; }
        public string CustomerBaName { get; set; }
        public int NOM_MONTHLY_QTY { get; set; }
        public int Level { get; set; }
        public double GPPLastDayDelVolume { get; set; }
        public double GPPLastDayRecVolume { get; set; }
        public string GasFlowDateString { get; set; }
        public double? NOM_RCV_QTY { get; set; }
        public double? ACT_RCV_QTY { get; set; }
        public double? SCH_RCV_VOL { get; set; }
        public string UPCNTR { get; set; }
        public double? CONFIRM_RCV_QTY { get; set; }
        public string NOM_STATUS_DAILY { get; set; }
        public double? ST_RATCHET_MDQ { get; set; }
        public double? ST_RATCHET_CUM_USAGE { get; set; }
        public double? ST_RATCHET_REM_MSQ { get; set; }
        public double? ST_RATCHET_TO_LEVEL { get; set; }
        public double? ST_RATCHET_FROM_LEVEL { get; set; }
        public bool OnSystemNomination { get; set; }
        public string UP_TRANS_POINT_ID { get; set; }
        public string DN_TRANS_POINT_ID { get; set; }
        public double NOM_OFF_Daily_RCV_VOL { get; }
        public double CUMULATIVE_NOM_Daily_RCV_VOL { get; }
        public double? CONFIRM_RCV_VOL { get; set; }
        public double? ACT_RCV_VOL { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Phone_Num { get; set; }
        public string Fax_Num { get; set; }
        public string TransporterName { get; set; }
        public string PIPELINE_NAME { get; }
        public string ACTIV_ALT_NUMForViewPkgs { get; }
        public string CNTR_ALT_NUM1ForViewPkgs { get; }
        public string REC_PT_ID { get; }
        public bool IsAMSchPkg { get; set; }
        public string DEL_PT_ID { get; }
        public int AmendAvailableQty { get; set; }
        public string Background { get; set; }
        public double UpDlvCost { get; }
        public double FuelQty { get; }
        public double FuelCost { get; }
        public double PathFee { get; }
        public double CumCost { get; }
        public double PathCost { get; }
        public double DvlCost { get; }
        public double Amount { get; }
        public double UpWACOG { get; }
        public double DlvWACOG { get; }
        public string Property1 { get; set; }
        public bool IsQtyApplyFullDuration { get; set; }
        public string DN_CONTRACT { get; set; }
        public string NOM_DAILY_STATUS { get; set; }
        public double CUMULATIVE_OFF_NOM_Daily_RCV_VOL { get; }
        public double FEE { get; }
        public string ACTIV_ALT_NUM { get; set; }
        public string CNTR_ALT_NUM1 { get; set; }
        public string CNTR_PARTY { get; set; }
        public string CNTR_TITLE { get; set; }
        public string RCV_POINT_ID { get; set; }
        public string DLV_POINT_ID { get; set; }
        public string UP_SHIPPER_NAME { get; set; }
        public string UP_CNTR { get; set; }
        public string UP_CNTR_pad { get; }
        public string UP_TRANSPORTER_NAME { get; set; }
        public string CUS_NAME { get; set; }
        public string DN_CNTR { get; set; }
        public string DN_TRANSPORTER_NAME { get; set; }
        public double? RcvValue { get; set; }
        public double? DlvValue { get; set; }
        public double NOM_RCV_VOL { get; set; }
        public double? SCH_RCV_VOL_4CG { get; set; }
        public double SCH_RCV_VOL_DURATION { get; set; }
        public double? NOM_PRICE { get; set; }
        public string SUPPLIER_NAME { get; set; }
        public string UP_TRANS_K { get; set; }
        public string RCV_POINT_NAME { get; set; }
        public string DLV_POINT_NAME { get; set; }
        public string AGENT_BANAME { get; set; }
        public string AGENT_BAID { get; set; }
        public string RANK { get; set; }
        public int TwoDaysOutQty { get; set; }
        public int NextDayQty { get; set; }
        public int PrevDayQty { get; set; }
        public string BID_NUM { get; set; }
        public string FORMULA_ID { get; set; }
        public double? PRICE_OFFSET { get; set; }
        public string DISPOSITION_NUM { get; set; }
        public string GASFLOW_DIR_INDIC { get; set; }
        public double? QUANTITY { get; set; }
        public string PKGTYPE { get; set; }
        public string STATUS { get; set; }
        public string BUS_SEGMENT { get; set; }
        public double? PRICE { get; set; }
        public int? CHG_FLOW_INDIC { get; set; }
        public string UNIT_MEAS { get; set; }
        public string ADJ_CODE { get; set; }
        public string BIDTYPE { get; set; }
        public string ROUTE_ID { get; set; }
        public string PACKAGE_LINK { get; set; }
        public string PRICE_LOCK { get; set; }
        public string SPLIT_FLAG { get; set; }
        public string CNTR_PATH_RATE_NUM { get; set; }
    }
}
