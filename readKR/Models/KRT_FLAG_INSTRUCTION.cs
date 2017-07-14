namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_FLAG_INSTRUCTION : DataEntityBase<string>
    {
        public KRT_FLAG_INSTRUCTION()
        {
        }

        public KRT_FLAG_INSTRUCTION(string code)
        {
            code.ShouldNotBeWhiteSpace("code");
            this.Id = code;
        }

        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string FILE_NAME_EN { get; set; }

        public virtual string FILE_NAME_KR { get; set; }

        public virtual string INS_NAME { get; set; }

        public virtual DateTime? UPDATE_DATE { get; set; }
    }
}

