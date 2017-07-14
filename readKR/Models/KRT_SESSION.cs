namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_SESSION : DataEntityBase<string>
    {
        public KRT_SESSION()
        {
        }

        public KRT_SESSION(string userId)
        {
            userId.ShouldNotBeWhiteSpace("userId");
            this.Id = userId;
        }

        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string SESSIONID { get; set; }

        public virtual string USRIP { get; set; }

        public virtual DateTime VISITDATE { get; set; }
    }
}

