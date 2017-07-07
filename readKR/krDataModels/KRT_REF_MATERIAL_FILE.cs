namespace KRkrDataModels
{
    using System;
    using System.Data;
    [Serializable]
    public class KRT_REF_MATERIAL_FILE 
    {  
        public KRT_REF_MATERIAL_FILE(DataRow row)
        {
            this.FILE_ID = Convert.ToInt32(row["FILE_ID"]);
            this.CONTENT_EN = row["CONTENT_EN"].ToString();
            this.CONTENT_KO = row["CONTENT_KO"].ToString();
            this.CONTENT_ZH = row["CONTENT_ZH"].ToString();
            this.FILE_NAME = row["FILE_NAME"].ToString();
            this.FILE_PATH = row["FILE_PATH"].ToString();
            this.FILE_ORDER = Convert.ToInt32(row["FILE_ORDER"]);
            this.REF_MATERIAL_ID = Convert.ToInt32(row["REF_MATERIAL_ID"]);
        }
        public virtual int FILE_ID { get; set; }     
        public virtual string CONTENT_EN { get; set; }
        public virtual string CONTENT_KO { get; set; }
        public virtual string CONTENT_ZH { get; set; }
        public virtual string FILE_NAME { get; set; }
        public virtual int FILE_ORDER { get; set; }
        public virtual string FILE_PATH { get; set; }
        public virtual int REF_MATERIAL_ID { get; set; }
    }
}
