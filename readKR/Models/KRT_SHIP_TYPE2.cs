namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_SHIP_TYPE2 : DataEntityBase<string>
    {
        public KRT_SHIP_TYPE2()
        {
        }

        public KRT_SHIP_TYPE2(string id, string name, int order, string certMandatory, string certOptional, int dept)
        {
            id.ShouldNotBeWhiteSpace("id");
            this.Id = id;
            this.SHIP_TYPE_NAME = name;
            this.SHIP_ORDER = order;
            this.CERT_MANDATORY = certMandatory;
            this.CERT_OPTIONAL = certOptional;
            this.SHIP_DEPTH = dept;
        }

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

        [Obsolete]
        public virtual string CERT_MANDATORY { get; set; }

        [Obsolete]
        public virtual string CERT_OPTIONAL { get; set; }

        public virtual int SHIP_DEPTH { get; set; }

        public virtual int SHIP_ORDER { get; set; }

        public virtual string SHIP_TYPE_NAME { get; set; }
    }
}

