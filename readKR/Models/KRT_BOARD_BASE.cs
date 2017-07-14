namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_BOARD_BASE : DataEntityBase<int>
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

        public virtual string BOARD_CONTENTS { get; set; }

        public virtual string BOARD_KINDS { get; set; }

        public virtual string BOARD_TITLE { get; set; }

        public virtual string FILE1 { get; set; }

        public virtual string FILE2 { get; set; }

        public virtual string FILE3 { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual string RELATION_CODE { get; set; }

        public virtual bool TOP { get; set; }
    }
}

