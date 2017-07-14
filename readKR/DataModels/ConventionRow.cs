using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace DataModels
{
    public static class ConventionOptions
    {
        public enum CATEGORY
        {
            IS_CATEGORY = 1,
            IS_CONTENT = 2,
        }
        public enum DISPLAY
        {
            IS_DISPLAY = 0,
            IS_HIDE = 1,
        }
    }
    class ConventionRow
    {
        public const int FIELDCOUNT= 21;//一条公约记录的字段数
        private void ConventionRow_Init()
        {
            this.Purposes = 0;
            this.Display = (int)ConventionOptions.DISPLAY.IS_DISPLAY;
            this.ConventionTypeKey = 3;
        }
        
        /// <summary>
        /// 用于创建根节点,参数为父节点参数
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="depth"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="IDfolder"></param>
        /// <param name="titlecnfolder"></param>
        public ConventionRow(Guid guid,int depth,string IDfolder,string titlecnfolder)
        {
            this.Category = (int)ConventionOptions.CATEGORY.IS_CATEGORY;
            this.Guid = guid;
            this.Depth = depth;
            ConventionRow_Init();
            this.IDFolder = IDfolder;
            this.TitleCnFolder = this.TitleEnFolder = titlecnfolder;
        }
       
        /// <summary>
        /// 根据指定的父节点创建子记录
        /// </summary>
        /// <param name="parentConventionRow"></param>
        /// <param name="titleCn"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="category"></param>
        /// <param name="tagcn"></param>
        public ConventionRow(ConventionRow parentConventionRow, string titleCn,
            int sequenceNumber, ConventionOptions.CATEGORY category,string tagcn=null)
        {
            this.TitleCn = this.TitleEn = this.ShortTitleCn = this.ShortTitleEn = titleCn;
            this.Category = (int)category;
            this.Guid = Guid.NewGuid();
            ConventionRow_Init();
            this.ParentNodeGuid = parentConventionRow.Guid;
            this.SequenceNumber = sequenceNumber;
            this.Depth = parentConventionRow.Depth+1;
            this.IDFolder = parentConventionRow.IDFolder + "#" + this.Guid;
            this.TitleCnFolder = this.TitleEnFolder=parentConventionRow.TitleCnFolder + "#@`" + this.TitleCn;
            this.TagCn  = tagcn; 
        }
        /// <summary>
        /// 新建一条记录，无需指定guid
        /// </summary>
        /// <param name="parentNodeGuid"></param>
        /// <param name="depth"></param>
        /// <param name="titleCn"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="category"></param>
        /// <param name="idfolder"></param>
        /// <param name="titlecnfolder"></param>
        public ConventionRow(Guid parentNodeGuid, int depth, string titleCn,
         int sequenceNumber, ConventionOptions.CATEGORY category,string idfolder,string titlecnfolder,string tag=null)
        {
            this.TitleCn = this.TitleEn = this.ShortTitleCn = this.ShortTitleEn = titleCn;
            this.Category = (int)category;
            this.Guid = Guid.NewGuid();
            ConventionRow_Init();
            this.ParentNodeGuid = parentNodeGuid;
            this.SequenceNumber = sequenceNumber;
            this.TagCn = tag;
            this.Depth = depth;
            this.IDFolder = idfolder;
            this.TitleCnFolder =this.TitleEnFolder= titlecnfolder;
        }            
        public Guid Guid { get; set; }
        public int Depth { get; set; }
        public Guid ParentNodeGuid { get; set; }
        public int SequenceNumber { get; set; }
        public int Category { get; set; }
        public string TitleCn { get; set; }
        public string TitleEn { get; set; }
        public string ShortTitleCn { get; set; }
        public string ShortTitleEn { get; set; }
        public string IDFolder { get; set; }
        public string TitleCnFolder { get; set; }
        public string TitleEnFolder { get; set; }
        public string TagCn { get; set; }
        public string TagEn { get; set; }
        public Guid QueryGuid { get; set; }
        public string Note { get; set; }      
        public int Display { get; set; }      
        public int Purposes { get; set; }
        public int ConventionTypeKey { get; set; }
        public DateTime LastEditDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}