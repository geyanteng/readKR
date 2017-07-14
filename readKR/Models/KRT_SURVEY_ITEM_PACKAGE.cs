namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_SURVEY_ITEM_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual DateTime? BLD_DATE_H { get; set; }

        public virtual DateTime? BLD_DATE_L { get; set; }

        public virtual bool CERT_CDG { get; set; }

        public virtual bool CERT_IAPP { get; set; }

        public virtual bool CERT_IBC { get; set; }

        public virtual bool CERT_IGC { get; set; }

        public virtual bool CERT_IGPP { get; set; }

        public virtual bool CERT_ILL { get; set; }

        public virtual bool CERT_IOPP { get; set; }

        public virtual bool CERT_ISPP { get; set; }

        public virtual bool CERT_PS { get; set; }

        public virtual bool CERT_SC { get; set; }

        public virtual bool CERT_SE { get; set; }

        public virtual bool CERT_SR { get; set; }

        public virtual string COMMENT { get; set; }

        public virtual int COMMENT_LEVEL { get; set; }

        public virtual string CONTENT_CODE { get; set; }

        public virtual int CONTENT_CODE_LEVEL { get; set; }

        public virtual string CONTENT_CODE2 { get; set; }

        public virtual int CONTENT_CODE2_LEVEL { get; set; }

        public virtual string CONTENT_CODE3 { get; set; }

        public virtual int CONTENT_CODE3_LEVEL { get; set; }

        public virtual string CONTENT_CODE4 { get; set; }

        public virtual int CONTENT_CODE4_LEVEL { get; set; }

        public virtual string CONTENT_CODE5 { get; set; }

        public virtual int CONTENT_CODE5_LEVEL { get; set; }

        public virtual DateTime? CONTRACT_DATE_H { get; set; }

        public virtual DateTime? CONTRACT_DATE_L { get; set; }

        public virtual DateTime? DELIVERY_DATE_H { get; set; }

        public virtual DateTime? DELIVERY_DATE_L { get; set; }

        public virtual bool DETAIL_ASPS { get; set; }

        public virtual bool DETAIL_DRAWING { get; set; }

        public virtual bool DETAIL_INIT { get; set; }

        public virtual bool DETAIL_ISPS { get; set; }

        public virtual bool DETAIL_OP { get; set; }

        public virtual bool DETAIL_PSC { get; set; }

        public virtual bool DETAIL_RS { get; set; }

        public virtual int DWT_H { get; set; }

        public virtual int DWT_L { get; set; }

        public virtual DateTime? EFF_DATE { get; set; }

        public virtual int EXCEL_REALESE_ID { get; set; }

        public virtual DateTime? EXP_DATE { get; set; }

        public virtual int GT_H { get; set; }

        public virtual int GT_L { get; set; }

        public virtual string IMAGE1 { get; set; }

        public virtual int IMAGE1_LEVEL { get; set; }

        public virtual string IMAGE2 { get; set; }

        public virtual int IMAGE2_LEVEL { get; set; }

        public virtual string IMAGE3 { get; set; }

        public virtual int IMAGE3_LEVEL { get; set; }

        public virtual int LF_H { get; set; }

        public virtual int LF_L { get; set; }

        public virtual int LOA_H { get; set; }

        public virtual int LOA_L { get; set; }

        public virtual int PASS_TOTAL_H { get; set; }

        public virtual int PASS_TOTAL_L { get; set; }

        public virtual bool PLACE_ACCOM { get; set; }

        public virtual bool PLACE_CARGO { get; set; }

        public virtual bool PLACE_ENGINE { get; set; }

        public virtual bool PLACE_NAVI { get; set; }

        public virtual string PRINT_GRP_L { get; set; }

        public virtual string PRINT_GRP_M { get; set; }

        public virtual string PRINT_GRP_S { get; set; }

        public virtual bool PRINT_IMPORTANT { get; set; }

        public virtual int PRINT_ORDER { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual string RELATION_CODE { get; set; }

        public virtual bool SHIP_All { get; set; }

        public virtual bool SHIP_ALL_CARGO { get; set; }

        public virtual bool SHIP_ALL_PASSENGER { get; set; }

        public virtual bool SHIP_BULK_CARRIERS { get; set; }

        public virtual bool SHIP_CHEMICAL_TANKERS { get; set; }

        public virtual bool SHIP_GAS_CARRIERS { get; set; }

        public virtual bool SHIP_HIGH_SPEED_CRAFT { get; set; }

        public virtual bool SHIP_MODU { get; set; }

        public virtual bool SHIP_OIL_TANKERS { get; set; }

        public virtual bool SHIP_OILCHEMICAL_TANKERS { get; set; }

        public virtual bool SHIP_OTHER_CARGO { get; set; }

        public virtual bool SHIP_PASSENGER { get; set; }

        public virtual bool SHIP_RORO_PASSENGER { get; set; }

        public virtual bool UMA { get; set; }
    }
}

