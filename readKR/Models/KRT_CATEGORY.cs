namespace KRCON.Data.Models
{
    using KRCON.Data;
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_CATEGORY : DataEntityBase<int>
    {
        public override int GetHashCode()
        {
            if (this.IsSaved)
            {
                return base.GetHashCode();
            }
            return this.CATEGORY_TREE.GetHashCode();
        }

        public override string ToString() => 
            this.ObjectToString();

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

        [Obsolete]
        public virtual bool IS_NEW { get; set; }

        public virtual bool IS_UMA { get; set; }

        public virtual bool IS_VIEWCHILD { get; set; }

        public virtual int LF_H { get; set; }

        public virtual int LF_H_1 { get; set; }

        public virtual int LF_L { get; set; }

        public virtual int LF_L_1 { get; set; }

        public virtual int LINK_CATEGORY { get; set; }

        public virtual string MEMO_HISTORY { get; set; }

        public virtual CategoryNodeKind NODE_TYPE { get; set; }

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

