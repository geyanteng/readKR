namespace DataModels
{
    using System;
    using System.Data;
    [Serializable]
    public class KRT_DATA
    {
        public KRT_DATA(DataRow row)
        {
            this.CATEGORY_TREE = row["CATEGORY_TREE"].ToString();
            this.INTEGRATION_ROOT = row["INTEGRATION_ROOT"].ToString();
            this.NOTE = row["NOTE"].ToString();
            this.CATEGORY_ID = Convert.ToInt32(row["CATEGORY_ID"]);
            this.CATEGORY_ORDER = Convert.ToInt32(row["CATEGORY_ORDER"]);
            this.GT_H = Convert.ToInt32(row["GT_H"]);
            this.GT_H_1 = Convert.ToInt32(row["GT_H_1"]);
            this.GT_L = Convert.ToInt32(row["GT_L"]);
            this.GT_L_1 = Convert.ToInt32(row["GT_L_1"]);
            this.LF_H = Convert.ToInt32(row["LF_H"]);
            this.LF_H_1 = Convert.ToInt32(row["LF_H_1"]);
            this.LF_L = Convert.ToInt32(row["LF_L"]);
            this.LF_L_1 = Convert.ToInt32(row["LF_L_1"]);
            this.PARENT_CATEGORY_ID = Convert.ToInt32(row["PARENT_CATEGORY_ID"]);
            this.PASS_TOTAL_H = Convert.ToInt32(row["PASS_TOTAL_H"]);
            this.PASS_TOTAL_H_1 = Convert.ToInt32(row["PASS_TOTAL_H_1"]);
            this.PASS_TOTAL_L = Convert.ToInt32(row["PASS_TOTAL_L"]);
            this.PASS_TOTAL_L_1 = Convert.ToInt32(row["PASS_TOTAL_L_1"]);
            this.IS_LEAF = Convert.ToBoolean(row["IS_LEAF"]);
            this.SHIP_All = Convert.ToBoolean(row["SHIP_All"]);
            this.SHIP_ALL_CARGO = Convert.ToBoolean(row["SHIP_ALL_CARGO"]);
            this.SHIP_ALL_PASSENGER = Convert.ToBoolean(row["SHIP_ALL_PASSENGER"]);
            this.SHIP_BULK_CARRIERS = Convert.ToBoolean(row["SHIP_BULK_CARRIERS"]);
            this.SHIP_CHEMICAL_TANKERS = Convert.ToBoolean(row["SHIP_CHEMICAL_TANKERS"]);
            this.SHIP_GAS_CARRIERS = Convert.ToBoolean(row["SHIP_GAS_CARRIERS"]);
            this.SHIP_HIGH_SPEED_CRAFT = Convert.ToBoolean(row["SHIP_HIGH_SPEED_CRAFT"]);
            this.SHIP_MODU = Convert.ToBoolean(row["SHIP_MODU"]);
            this.SHIP_OIL_TANKERS = Convert.ToBoolean(row["SHIP_OIL_TANKERS"]);
            this.SHIP_OILCHEMICAL_TANKERS = Convert.ToBoolean(row["SHIP_OILCHEMICAL_TANKERS"]);
            this.SHIP_OTHER_CARGO = Convert.ToBoolean(row["SHIP_OTHER_CARGO"]);
            this.SHIP_PASSENGER = Convert.ToBoolean(row["SHIP_PASSENGER"]);
            this.SHIP_RORO_PASSENGER = Convert.ToBoolean(row["SHIP_RORO_PASSENGER"]);
            this.CONTRACT_DATE_H = Convert.ToDateTime(row["CONTRACT_DATE_H"]);
            this.CONTRACT_DATE_L = Convert.ToDateTime(row["CONTRACT_DATE_L"]);
            this.DATE_ADOPTED = Convert.ToDateTime(row["DATE_ADOPTED"]);
            this.DATE_BUILD_H = Convert.ToDateTime(row["DATE_BUILD_H"]);
            this.DATE_BUILD_L = Convert.ToDateTime(row["DATE_BUILD_L"]);
            this.DATE_EFFECTIVE = Convert.ToDateTime(row["DATE_EFFECTIVE"]);
            this.DATE_EXP = Convert.ToDateTime(row["DATE_EXP"]);
            this.DELIVERY_DATE_H = Convert.ToDateTime(row["DELIVERY_DATE_H"]);
            this.DELIVERY_DATE_L = Convert.ToDateTime(row["DELIVERY_DATE_L"]);
        }
        public virtual int CATEGORY_ID { get; set; }
        public virtual int CATEGORY_ORDER { get; set; }
        public virtual string CATEGORY_TREE { get; set; }
        public virtual DateTime? CONTRACT_DATE_H { get; set; }
        public virtual DateTime? CONTRACT_DATE_L { get; set; }
        public virtual DateTime? DATE_ADOPTED { get; set; }
        public virtual DateTime? DATE_BUILD_H { get; set; }
        public virtual DateTime? DATE_BUILD_L { get; set; }
        public virtual DateTime? DATE_EFFECTIVE { get; set; }
        public virtual DateTime? DATE_EXP { get; set; }
        public virtual DateTime? DELIVERY_DATE_H { get; set; }
        public virtual DateTime? DELIVERY_DATE_L { get; set; }
        public virtual int GT_H { get; set; }
        public virtual int GT_H_1 { get; set; }
        public virtual int GT_L { get; set; }
        public virtual int GT_L_1 { get; set; }      
        public string Retroactive = "Retroactive: Retroactive Requirement for Existing Ships."; 
        public virtual bool IS_LEAF { get; set; }
        public virtual int LF_H { get; set; }
        public virtual int LF_H_1 { get; set; }
        public virtual int LF_L { get; set; }
        public virtual int LF_L_1 { get; set; }        
        public virtual string NOTE { get; set; }
        public virtual int? PARENT_CATEGORY_ID { get; set; }
        public virtual int PASS_TOTAL_H { get; set; }
        public virtual int PASS_TOTAL_H_1 { get; set; }
        public virtual int PASS_TOTAL_L { get; set; }
        public virtual int PASS_TOTAL_L_1 { get; set; }
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

        public virtual string CATEGORY_DESC { get; set; }
        public virtual string CATEGORY_HEADER { get; set; }
        public virtual int CATEGORY_TEXT_ID { get; set; }
        public virtual string CATEGORY_TITLE { get; set; }
        public virtual string LOCALE_KEY { get; set; }
        public virtual int? LINK_CATEGORY { get; set; }
        public virtual string INTEGRATION_ROOT { get; set; }
        public virtual string CHAPTER_YEAR_ROOT { get; set; }

        public Guid GUID;
        public Guid PARENT_GUID;

    }
}

