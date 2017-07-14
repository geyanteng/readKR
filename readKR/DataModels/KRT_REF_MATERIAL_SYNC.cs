namespace DataModels
{   
    using System;
    using System.Data;
    [Serializable]
    public class KRT_REF_MATERIAL_SYNC 
    {
        public KRT_REF_MATERIAL_SYNC(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.CATEGORY_TEXT_ID = Convert.ToInt32(row["CATEGORY_TEXT_ID"]);
            this.REF_MATERIAL_ID = Convert.ToInt32(row["REF_MATERIAL_ID"]);
            this.VIEW_COUNT = Convert.ToInt32(row["VIEW_COUNT"]);
        }
        public virtual int Id { get; set; }
        public virtual int CATEGORY_TEXT_ID { get; set; }
        public virtual int REF_MATERIAL_ID { get; set; }
        public virtual int VIEW_COUNT { get; set; }
    }
}
