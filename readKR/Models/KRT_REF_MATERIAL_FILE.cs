namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_REF_MATERIAL_FILE : DataEntityBase<int>
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

        public virtual string CONTENT_EN { get; set; }

        public virtual string CONTENT_KO { get; set; }

        public virtual string CONTENT_ZH { get; set; }

        public virtual string FILE_NAME { get; set; }

        public virtual int FILE_ORDER { get; set; }

        public virtual string FILE_PATH { get; set; }

        public virtual int REF_MATERIAL_ID { get; set; }
    }
}

