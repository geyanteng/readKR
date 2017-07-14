namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_CATEGORY_TEXT : DataEntityBase<int>
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

        public virtual string CATEGORY_DESC { get; set; }

        public virtual int CATEGORY_ID { get; set; }

        public virtual string CATEGORY_TITLE { get; set; }

        public virtual string DATA_TEXT { get; set; }

        public virtual string DATA_XML { get; set; }

        public virtual string DATA_XML_TRANSFORM { get; set; }

        public virtual bool IS_COMPLETED { get; set; }

        public virtual bool IS_VISIBLE { get; set; }

        public virtual string LOCALE_KEY { get; set; }

        public virtual DateTime? UPDATE_DATE { get; set; }

        public virtual string USER_ID { get; set; }
    }
}

