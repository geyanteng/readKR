namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_IMO_CATEGORY : DataEntityBase<int>
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

        public virtual string CATEGORY_DESC { get; set; }

        public virtual int CATEGORY_ORDER { get; set; }

        public virtual string CATEGORY_TITLE { get; set; }

        public virtual string CATEGORY_TREE { get; set; }

        public virtual string CONTENT_CODE { get; set; }

        public virtual DateTime? DATE_ADOPTED { get; set; }

        public virtual bool IS_LEAF { get; set; }

        public virtual string NOTE { get; set; }

        public virtual int? PARENT_CATEGORY_ID { get; set; }

        public virtual string PDF_FILE { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }
    }
}

