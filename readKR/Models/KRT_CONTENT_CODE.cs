namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_CONTENT_CODE : DataEntityBase<string>
    {
        protected KRT_CONTENT_CODE()
        {
        }

        public KRT_CONTENT_CODE(string contentCode)
        {
            contentCode.ShouldNotBeWhiteSpace("contentCode");
            this.Id = contentCode;
        }

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

        public virtual string EN_TITLE { get; set; }

        public virtual string KO_TITLE { get; set; }

        public virtual string MEMO { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual string ZH_TITLE { get; set; }
    }
}

