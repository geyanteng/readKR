namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_PERMISSION_TREE : DataEntityBase<int>
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

        public virtual string CATEGORY_TREE { get; set; }

        public virtual string CONTENT_CODE { get; set; }

        public virtual bool CREATABLE { get; set; }

        public virtual bool DELETABLE { get; set; }

        public virtual string PTREE_NAME { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual bool UPDATABLE { get; set; }

        public virtual string USER_ID { get; set; }
    }
}

