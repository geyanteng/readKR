namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_CONVENTION_TODAY_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual bool ADMINISTRATION { get; set; }

        public virtual bool ALL_CARGO_SHIPS { get; set; }

        public virtual bool ALL_PASSENGER_SHIPS { get; set; }

        public virtual bool ALL_SHIPS { get; set; }

        public virtual bool AMEND { get; set; }

        public virtual bool AMEND_RETROACTIVE { get; set; }

        public virtual string APPLICATION_E { get; set; }

        public virtual string APPLICATION_K { get; set; }

        public virtual bool BULK_CARRIER { get; set; }

        public virtual string CHAPTER { get; set; }

        public virtual bool CHEMICAL_TANKER { get; set; }

        public virtual DateTime? CONSTRUCTION_DATE { get; set; }

        public virtual string CONTENT_E { get; set; }

        public virtual string CONTENT_K { get; set; }

        public virtual DateTime? CONTRACT_DATE { get; set; }

        public virtual string CONVENTION { get; set; }

        public virtual DateTime? DELIVERY_DATE { get; set; }

        public virtual DateTime? EFFECTIVE_DATE { get; set; }

        public virtual bool EQ { get; set; }

        public virtual bool EXPECTED { get; set; }

        public virtual DateTime? EXPIRY_DATE { get; set; }

        public virtual bool GAS_CARRIER { get; set; }

        public virtual bool HIGH_SPEED_CRAFT { get; set; }

        public virtual string IMO_DOCUMENT { get; set; }

        public virtual bool LOCAL_REGULATION { get; set; }

        public virtual bool MODU { get; set; }

        public virtual string NOTE { get; set; }

        public virtual bool OIL_TANKER { get; set; }

        public virtual bool OP { get; set; }

        public virtual bool OTHER_TYPE_SHIPS { get; set; }

        public virtual bool PASSENGER_SHIPS { get; set; }

        public virtual bool REFERENCE { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual string REGULATION { get; set; }

        public virtual string RELEVANT_DOCUMENT { get; set; }

        public virtual string RELEVANT_DOCUMENT_LINK { get; set; }

        public virtual string REMARK_E { get; set; }

        public virtual string REMARK_K { get; set; }

        public virtual string REMARK_LINK_E { get; set; }

        public virtual string REMARK_LINK_K { get; set; }

        public virtual bool RO_RO_PASSENGER_SHIPS { get; set; }

        public virtual bool TE { get; set; }

        public virtual string TITLE_E { get; set; }

        public virtual string TITLE_K { get; set; }

        public virtual bool UI { get; set; }
    }
}

