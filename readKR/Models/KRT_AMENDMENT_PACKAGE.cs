namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_AMENDMENT_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string CERTIFICATE { get; set; }

        public virtual string CHAPTER_TITLE { get; set; }

        public virtual string NEXT_CODE { get; set; }

        public virtual string NEXT_TITLE { get; set; }

        public virtual int ORDER { get; set; }

        public virtual string PREV_CODE { get; set; }

        public virtual string PREV_TITLE { get; set; }

        public virtual DateTime REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual string REGULATION_TITLE { get; set; }
    }
}

