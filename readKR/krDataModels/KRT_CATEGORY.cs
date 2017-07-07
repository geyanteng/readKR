namespace krDataModels
{
    using System;
    using System.Data;
    [Serializable]
    public class KRT_CATEGORY 
    {
        public KRT_CATEGORY(DataRow row)
        {
            this.ADAPTED_BY = row["ADAPTED_BY"].ToString();
            this.CATEGORY_TREE = row["CATEGORY_TREE"].ToString();
            this.CHAPTER_YEAR_ROOT = row["CHAPTER_YEAR_ROOT"].ToString();
            this.CONTENT_CODE = row["CONTENT_CODE"].ToString();
            this.INTEGRATION_ROOT = row["INTEGRATION_ROOT"].ToString();
            this.MEMO_HISTORY = row["MEMO_HISTORY"].ToString();
            this.NOTE = row["NOTE"].ToString();
            this.REG_ID = row["REG_ID"].ToString();
            this.TREE_GROUP = row["TREE_GROUP"].ToString();
            this.TREE_GROUP_TITLE = row["TREE_GROUP_TITLE"].ToString();
            this.CATEGORY_ID = Convert.ToInt32(row["CATEGORY_ID"]);
            this.CATEGORY_ORDER = Convert.ToInt32(row["CATEGORY_ORDER"]);
            this.CATEGORY_ORDER_EMSA = Convert.ToInt32(row["CATEGORY_ORDER_EMSA"]);
            this.CATEGORY_ORDER_MED = Convert.ToInt32(row["CATEGORY_ORDER_MED"]);
            this.GT_H = Convert.ToInt32(row["GT_H"]);
            this.GT_H_1 = Convert.ToInt32(row["GT_H_1"]);
            this.GT_L = Convert.ToInt32(row["GT_L"]);
            this.GT_L_1 = Convert.ToInt32(row["GT_L_1"]);
            this.LF_H = Convert.ToInt32(row["LF_H"]);
            this.LF_H_1 = Convert.ToInt32(row["LF_H_1"]);
            this.LF_L = Convert.ToInt32(row["LF_L"]);
            this.LF_L_1 = Convert.ToInt32(row["LF_L_1"]);
            this.LINK_CATEGORY = Convert.ToInt32(row["LINK_CATEGORY"]);
            this.NODE_TYPE = Convert.ToInt32(row["NODE_TYPE"]);
            this.PARENT_CATEGORY_ID = Convert.ToInt32(row["PARENT_CATEGORY_ID"]);
            this.PASS_TOTAL_H = Convert.ToInt32(row["PASS_TOTAL_H"]);
            this.PASS_TOTAL_H_1 = Convert.ToInt32(row["PASS_TOTAL_H_1"]);
            this.PASS_TOTAL_L = Convert.ToInt32(row["PASS_TOTAL_L"]);
            this.PASS_TOTAL_L_1 = Convert.ToInt32(row["PASS_TOTAL_L_1"]);
            this.SECURITY_LEVEL = Convert.ToInt32(row["SECURITY_LEVEL"]);
            this.IS_ADOPTED = Convert.ToBoolean(row["IS_ADOPTED"]);
            this.IS_BACKTO = Convert.ToBoolean(row["IS_BACKTO"]);
            this.IS_DYNAMIC_TREE = Convert.ToBoolean(row["IS_DYNAMIC_TREE"]);
            this.IS_EMSA_DATA = Convert.ToBoolean(row["IS_EMSA_DATA"]);
            this.IS_HEADER = Convert.ToBoolean(row["IS_HEADER"]);
            this.IS_KRCON_DATA = Convert.ToBoolean(row["IS_KRCON_DATA"]);
            this.IS_LEAF = Convert.ToBoolean(row["IS_LEAF"]);
            this.IS_MED_DATA = Convert.ToBoolean(row["IS_MED_DATA"]);
            this.IS_NEW = Convert.ToBoolean(row["IS_NEW"]);
            this.IS_UMA = Convert.ToBoolean(row["IS_UMA"]);
            this.IS_VIEWCHILD = Convert.ToBoolean(row["IS_VIEWCHILD"]);
            this.SHIP_All = Convert.ToBoolean(row["SHIP_All"]);
            this.SHIP_All_1 = Convert.ToBoolean(row["SHIP_All_1"]);
            this.SHIP_ALL_CARGO = Convert.ToBoolean(row["SHIP_ALL_CARGO"]);
            this.SHIP_ALL_CARGO_1 = Convert.ToBoolean(row["SHIP_ALL_CARGO_1"]);
            this.SHIP_ALL_PASSENGER = Convert.ToBoolean(row["SHIP_ALL_PASSENGER"]);
            this.SHIP_ALL_PASSENGER_1 = Convert.ToBoolean(row["SHIP_ALL_PASSENGER_1"]);
            this.SHIP_BULK_CARRIERS = Convert.ToBoolean(row["SHIP_BULK_CARRIERS"]);
            this.SHIP_BULK_CARRIERS_1 = Convert.ToBoolean(row["SHIP_BULK_CARRIERS_1"]);
            this.SHIP_CHEMICAL_TANKERS = Convert.ToBoolean(row["SHIP_CHEMICAL_TANKERS"]);
            this.SHIP_CHEMICAL_TANKERS_1 = Convert.ToBoolean(row["SHIP_CHEMICAL_TANKERS_1"]);
            this.SHIP_GAS_CARRIERS = Convert.ToBoolean(row["SHIP_GAS_CARRIERS"]);
            this.SHIP_GAS_CARRIERS_1 = Convert.ToBoolean(row["SHIP_GAS_CARRIERS_1"]);
            this.SHIP_HIGH_SPEED_CRAFT = Convert.ToBoolean(row["SHIP_HIGH_SPEED_CRAFT"]);
            this.SHIP_HIGH_SPEED_CRAFT_1 = Convert.ToBoolean(row["SHIP_HIGH_SPEED_CRAFT_1"]);
            this.SHIP_MODU = Convert.ToBoolean(row["SHIP_MODU"]);
            this.SHIP_MODU_1 = Convert.ToBoolean(row["SHIP_MODU_1"]);
            this.SHIP_OIL_TANKERS = Convert.ToBoolean(row["SHIP_OIL_TANKERS"]);
            this.SHIP_OIL_TANKERS_1 = Convert.ToBoolean(row["SHIP_OIL_TANKERS_1"]);
            this.SHIP_OILCHEMICAL_TANKERS = Convert.ToBoolean(row["SHIP_OILCHEMICAL_TANKERS"]);
            this.SHIP_OILCHEMICAL_TANKERS_1 = Convert.ToBoolean(row["SHIP_OILCHEMICAL_TANKERS_1"]);
            this.SHIP_OTHER_CARGO = Convert.ToBoolean(row["SHIP_OTHER_CARGO"]);
            this.SHIP_OTHER_CARGO_1 = Convert.ToBoolean(row["SHIP_OTHER_CARGO_1"]);
            this.SHIP_PASSENGER = Convert.ToBoolean(row["SHIP_PASSENGER"]);
            this.SHIP_PASSENGER_1 = Convert.ToBoolean(row["SHIP_PASSENGER_1"]);
            this.SHIP_RORO_PASSENGER = Convert.ToBoolean(row["SHIP_RORO_PASSENGER"]);
            this.SHIP_RORO_PASSENGER_1 = Convert.ToBoolean(row["SHIP_RORO_PASSENGER_1"]);
            this.CONTRACT_DATE_H = Convert.ToDateTime(row["CONTRACT_DATE_H"]);
            this.CONTRACT_DATE_L = Convert.ToDateTime(row["CONTRACT_DATE_L"]);
            this.DATE_ADOPTED = Convert.ToDateTime(row["DATE_ADOPTED"]);
            this.DATE_BUILD_H = Convert.ToDateTime(row["DATE_BUILD_H"]);
            this.DATE_BUILD_L = Convert.ToDateTime(row["DATE_BUILD_L"]);
            this.DATE_EFFECTIVE = Convert.ToDateTime(row["DATE_EFFECTIVE"]);
            this.DATE_EXP = Convert.ToDateTime(row["DATE_EXP"]);
            this.DELIVERY_DATE_H = Convert.ToDateTime(row["DELIVERY_DATE_H"]);
            this.DELIVERY_DATE_L = Convert.ToDateTime(row["DELIVERY_DATE_L"]);
            this.REG_DATE = Convert.ToDateTime(row["REG_DATE"]);
        }
        public virtual int CATEGORY_ID { get; set; }
        public virtual string ADAPTED_BY { get; set; }
        public virtual int CATEGORY_ORDER { get; set; }
        public virtual int CATEGORY_ORDER_EMSA { get; set; }
        public virtual int CATEGORY_ORDER_MED { get; set; }
        public virtual string CATEGORY_TREE { get; set; }
        public virtual string CHAPTER_YEAR_ROOT { get; set; }
        public virtual string CONTENT_CODE { get; set; }
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
        public virtual string INTEGRATION_ROOT { get; set; }
        public virtual bool IS_ADOPTED { get; set; }
        public virtual bool IS_BACKTO { get; set; }
        public virtual bool IS_DYNAMIC_TREE { get; set; }
        public virtual bool IS_EMSA_DATA { get; set; }
        public virtual bool IS_HEADER { get; set; }
        public virtual bool IS_KRCON_DATA { get; set; }
        public virtual bool IS_LEAF { get; set; }
        public virtual bool IS_MED_DATA { get; set; }
        public virtual bool IS_NEW { get; set; }
        public virtual bool IS_UMA { get; set; }
        public virtual bool IS_VIEWCHILD { get; set; }
        public virtual int LF_H { get; set; }
        public virtual int LF_H_1 { get; set; }
        public virtual int LF_L { get; set; }
        public virtual int LF_L_1 { get; set; }
        public virtual int LINK_CATEGORY { get; set; }
        public virtual string MEMO_HISTORY { get; set; }
        public virtual int NODE_TYPE { get; set; }
        public virtual string NOTE { get; set; }
        public virtual int? PARENT_CATEGORY_ID { get; set; }
        public virtual int PASS_TOTAL_H { get; set; }
        public virtual int PASS_TOTAL_H_1 { get; set; }
        public virtual int PASS_TOTAL_L { get; set; }
        public virtual int PASS_TOTAL_L_1 { get; set; }
        public virtual DateTime? REG_DATE { get; set; }
        public virtual string REG_ID { get; set; }
        public virtual int SECURITY_LEVEL { get; set; }
        public virtual bool SHIP_All { get; set; }
        public virtual bool SHIP_All_1 { get; set; }
        public virtual bool SHIP_ALL_CARGO { get; set; }
        public virtual bool SHIP_ALL_CARGO_1 { get; set; }
        public virtual bool SHIP_ALL_PASSENGER { get; set; }
        public virtual bool SHIP_ALL_PASSENGER_1 { get; set; }
        public virtual bool SHIP_BULK_CARRIERS { get; set; }
        public virtual bool SHIP_BULK_CARRIERS_1 { get; set; }
        public virtual bool SHIP_CHEMICAL_TANKERS { get; set; }
        public virtual bool SHIP_CHEMICAL_TANKERS_1 { get; set; }
        public virtual bool SHIP_GAS_CARRIERS { get; set; }
        public virtual bool SHIP_GAS_CARRIERS_1 { get; set; }
        public virtual bool SHIP_HIGH_SPEED_CRAFT { get; set; }
        public virtual bool SHIP_HIGH_SPEED_CRAFT_1 { get; set; }
        public virtual bool SHIP_MODU { get; set; }
        public virtual bool SHIP_MODU_1 { get; set; }
        public virtual bool SHIP_OIL_TANKERS { get; set; }
        public virtual bool SHIP_OIL_TANKERS_1 { get; set; }
        public virtual bool SHIP_OILCHEMICAL_TANKERS { get; set; }
        public virtual bool SHIP_OILCHEMICAL_TANKERS_1 { get; set; }
        public virtual bool SHIP_OTHER_CARGO { get; set; }
        public virtual bool SHIP_OTHER_CARGO_1 { get; set; }
        public virtual bool SHIP_PASSENGER { get; set; }
        public virtual bool SHIP_PASSENGER_1 { get; set; }
        public virtual bool SHIP_RORO_PASSENGER { get; set; }
        public virtual bool SHIP_RORO_PASSENGER_1 { get; set; }
        public virtual string TREE_GROUP { get; set; }
        public virtual string TREE_GROUP_TITLE { get; set; }
    }
}
