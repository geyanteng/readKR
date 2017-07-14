namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_LOCALE_KEYS : DataEntityBase<string>
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

        public virtual string DESCRIPTION { get; set; }

        public virtual bool IS_ACTIVE { get; set; }

        public virtual bool IS_DEFAULT { get; set; }

        public virtual string LANGUAGE { get; set; }

        public virtual string LOCALE_NAME { get; set; }
    }
}

