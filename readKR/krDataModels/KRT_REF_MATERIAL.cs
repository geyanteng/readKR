namespace krDataModels
{
    using System;
    using System.Data;
    [Serializable]
    public class KRT_REF_MATERIAL
    {
        public KRT_REF_MATERIAL(DataRow row)
        {
            this.seq = Convert.ToInt32(row["seq"]);
            this.category_title = row["category_title"].ToString();
            this.category_tree = row["category_tree"].ToString();
            this.content_cha = row["content_cha"].ToString();
            this.content_eng = row["content_eng"].ToString();
            this.content_kor = row["content_kor"].ToString();
            this.title_cha = row["title_cha"].ToString();
            this.title_eng = row["title_eng"].ToString();
            this.title_kor = row["title_kor"].ToString();
            this.delchk = Convert.ToBoolean(row["delchk"]);
            this.writedate = Convert.ToDateTime(row["writedate"]);
        }
        public virtual int seq { get; set; }      
        public virtual string category_title { get; set; }
        public virtual string category_tree { get; set; }
        public virtual string content_cha { get; set; }
        public virtual string content_eng { get; set; }
        public virtual string content_kor { get; set; }
        public virtual bool? delchk { get; set; }
        public virtual string title_cha { get; set; }
        public virtual string title_eng { get; set; }
        public virtual string title_kor { get; set; }
        public virtual DateTime? writedate { get; set; }
    }
}
