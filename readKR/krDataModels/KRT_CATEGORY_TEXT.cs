namespace krDataModels
{
    using System;
    using System.Data;
    [Serializable]
    public class KRT_CATEGORY_TEXT 
    {    
        public KRT_CATEGORY_TEXT(DataRow row)
        {
            this.CATEGORY_DESC = row["CATEGORY_DESC"].ToString();
            this.CATEGORY_TITLE = row["CATEGORY_TITLE"].ToString();
            this.DATA_XML_TRANSFORM = row["DATA_XML_TRANSFORM"].ToString();
            this.LOCALE_KEY = row["LOCALE_KEY"].ToString();
            this.USER_ID = row["USER_ID"].ToString();
            this.DATA_TEXT = row["DATA_TEXT"].ToString();
            this.DATA_XML = row["DATA_XML"].ToString();
            this.CATEGORY_ID = Convert.ToInt32(row["CATEGORY_ID"]);
            this.CATEGORY_TEXT_ID = Convert.ToInt32(row["CATEGORY_TEXT_ID"]);
            this.IS_COMPLETED = Convert.ToBoolean(row["IS_COMPLETED"]);
            this.IS_VISIBLE = Convert.ToBoolean(row["IS_VISIBLE"]);
            this.UPDATE_DATE = Convert.ToDateTime(row["UPDATE_DATE"]);
        }  
        public virtual int CATEGORY_TEXT_ID { get; set; }
        public virtual string CATEGORY_DESC { get; set; }
        public virtual int CATEGORY_ID { get; set; }
        public virtual string CATEGORY_TITLE { get; set; }
        public virtual string DATA_TEXT { get; set; }
        public virtual string DATA_XML { get; set; }
        public virtual string DATA_XML_TRANSFORM { get; set; }
        public virtual bool IS_COMPLETED { get; set; }
        public virtual bool IS_VISIBLE { get; set; }
        public virtual string LOCALE_KEY { get; set; }
        public virtual DateTime? UPDATE_DATE { get; set; }
        public virtual string USER_ID { get; set; }
    }
}
