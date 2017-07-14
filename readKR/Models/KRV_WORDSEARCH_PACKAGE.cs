namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRV_WORDSEARCH_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.CATEGORY_TREE.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string CATEGORY_DESC { get; set; }

        public virtual string CATEGORY_HEADER { get; set; }

        public virtual int CATEGORY_ID { get; set; }

        public virtual string CATEGORY_TITLE { get; set; }

        public virtual string CATEGORY_TREE { get; set; }

        public virtual string CONTENT_CODE { get; set; }

        public virtual string CONTENT_HEADER { get; set; }

        public virtual string DATA_TEXT { get; set; }

        public virtual string FILE_PATH { get; set; }

        public virtual string FILE_TEXT { get; set; }

        public virtual bool IS_COMPLETED { get; set; }

        public virtual bool IS_LEAF { get; set; }

        public virtual bool IS_VISIBLE { get; set; }

        public virtual string LOCALE_KEY { get; set; }

        public virtual int SECURITY_LEVEL { get; set; }
    }
}

