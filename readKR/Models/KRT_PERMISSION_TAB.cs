namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_PERMISSION_TAB : DataEntityBase<string>
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

        public virtual bool CHECK_TAB { get; set; }

        public virtual bool CODE_TAB { get; set; }

        public virtual bool CONVENTION_TAB { get; set; }

        public virtual bool FAQ_TAB { get; set; }

        public virtual bool IMO_TAB { get; set; }

        public virtual bool LOG_TAB { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual bool STATUS_TAB { get; set; }

        public virtual bool SUBMAIN_TAB { get; set; }

        public virtual bool TAB_1 { get; set; }

        public virtual bool TAB_2 { get; set; }

        public virtual bool TAB_3 { get; set; }

        public virtual bool TAB_4 { get; set; }

        public virtual bool TAB_5 { get; set; }

        public virtual bool TREE_TAB { get; set; }

        public virtual bool UPDATE_TAB { get; set; }

        public virtual bool USER_TAB { get; set; }
    }
}

