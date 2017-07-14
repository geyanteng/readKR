namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_SURVEY_ITEM_TEXT_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string DETAIL { get; set; }

        public virtual string LOCALE_KEY { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual int SURVEY_ITEM_ID { get; set; }

        public virtual string TITLE { get; set; }
    }
}

