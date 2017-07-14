namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_UPDATE_HISTORY : DataEntityBase<int>
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

        public virtual DateTime CREATE_DATE { get; set; }

        public virtual string DESCRIPTION { get; set; }

        public virtual string FILE_PATH { get; set; }

        public virtual bool IS_POST { get; set; }

        public virtual int MAJOR_NO { get; set; }

        public virtual string MINOR_NO { get; set; }

        public virtual DateTime REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }
    }
}

