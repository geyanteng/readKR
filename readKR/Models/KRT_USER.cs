namespace KRCON.Data.Models
{
    using RCL.Core;
    using RCL.Data.NH;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable]
    public class KRT_USER : DataEntityBase<string>
    {
        protected KRT_USER()
        {
        }

        public KRT_USER(string userId)
        {
            userId.ShouldNotBeWhiteSpace("userId");
            this.Id = userId;
        }

        public override int GetHashCode() => 
            this.Id.GetHashCode();

        public override string ToString() => 
            this.ObjectToString();

        public virtual string ADDRESS1 { get; set; }

        public virtual string ADDRESS2 { get; set; }

        public virtual string CELL_PHONE { get; set; }

        public virtual string COMPANY { get; set; }

        public virtual string COUNTRY { get; set; }

        public virtual DateTime? CREATED_DATE { get; set; }

        public virtual string EMAIL { get; set; }

        public virtual bool EMAIL_RECEIVE { get; set; }

        public virtual DateTime? EXPIRED_DATE { get; set; }

        public virtual string FAX { get; set; }

        public virtual string FIRST_NAME { get; set; }

        public virtual int? IS_BUY { get; set; }

        public virtual bool IS_MULTI { get; set; }

        public virtual string LAST_NAME { get; set; }

        public virtual DateTime? LAST_VISITED_DATE { get; set; }

        public virtual string NOTE { get; set; }

        public virtual string PASSWORD { get; set; }

        public virtual DateTime? REG_DATE { get; set; }

        public virtual string REG_ID { get; set; }

        public virtual int? SECURITY_LEVEL { get; set; }

        public virtual string TEL { get; set; }

        public virtual int? VISIT_COUNT { get; set; }
    }
}

