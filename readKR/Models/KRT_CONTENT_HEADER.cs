namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_CONTENT_HEADER : DataEntityBase<int>
    {
        public override int GetHashCode()
        {
            if (this.IsSaved)
            {
                return base.GetHashCode();
            }
            return this.Id.GetHashCode();
        }

        public override string ToString() => 
            this.ObjectToString();

        public virtual string CONTENT_CODE { get; set; }

        public virtual string CONTENT_HEADER { get; set; }

        public virtual string CONTENT_HEADER_SELF { get; set; }

        public virtual string LOCALE_KEY { get; set; }

        public virtual string MEMO { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }
    }
}

