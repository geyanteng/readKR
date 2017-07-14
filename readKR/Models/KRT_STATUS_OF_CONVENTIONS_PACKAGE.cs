namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_STATUS_OF_CONVENTIONS_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual string SOC_FILE { get; set; }

        public virtual int SOC_KINDS { get; set; }

        public virtual string SOC_NOTE { get; set; }
    }
}

