namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_REF_MATERIAL : DataEntityBase<int>
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

        public virtual string category_title { get; set; }

        public virtual string category_tree { get; set; }

        public virtual string content_cha { get; set; }

        public virtual string content_eng { get; set; }

        public virtual string content_kor { get; set; }

        public virtual bool? delchk { get; set; }

        public virtual string title_cha { get; set; }

        public virtual string title_eng { get; set; }

        public virtual string title_kor { get; set; }

        public virtual DateTime? writedate { get; set; }
    }
}

