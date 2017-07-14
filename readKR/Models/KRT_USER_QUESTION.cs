namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_USER_QUESTION : DataEntityBase<int>
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

        public virtual bool? COMPLATED { get; set; }

        public virtual DateTime? CONFIRM_DATE { get; set; }

        public virtual int KIND { get; set; }

        public virtual string RESULT_XML { get; set; }

        public virtual string USER_ID { get; set; }
    }
}

