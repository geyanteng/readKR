namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_REF_MATERIAL_SYNC : DataEntityBase<int>
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

        public virtual int CATEGORY_TEXT_ID { get; set; }

        public virtual int REF_MATERIAL_ID { get; set; }

        public virtual int VIEW_COUNT { get; set; }
    }
}

