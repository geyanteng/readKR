namespace KRCON.Data.Models
{
    using RCL.Core;
    using System;

    [Serializable]
    public class KRT_DOWNLOAD : KRT_BOARD_BASE
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
    }
}

