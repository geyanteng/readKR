namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_FILE_PACKAGE : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string FILE_PATH { get; set; }

        public virtual string FILE_TEXT { get; set; }

        public virtual int FUNCTION_ID { get; set; }

        public virtual int FUNCTION_KIND { get; set; }

        public virtual string LOCALE_KEY { get; set; }

        public virtual DateTime REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }
    }
}

