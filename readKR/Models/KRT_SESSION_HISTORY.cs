namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_SESSION_HISTORY : DataEntityBase<int>
    {
        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string CATE { get; set; }

        public virtual DateTime EXEDATE { get; set; }

        public virtual string SESSIONID { get; set; }

        public virtual string USRID { get; set; }

        public virtual string USRIP { get; set; }

        public virtual DateTime VISITDATE { get; set; }
    }
}

