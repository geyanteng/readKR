using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace readKR
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.tbCategoryID.Text = 8778.ToString();
        }
        private KrDAO krDAO = KrDAO.getKrDAO();
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tbCategoryID.Text == string.Empty)
                return;
            string language;
            if (this.rbEn.Checked)
                language = "en";
            else
                language = "zh";
            int categoryID = int.Parse(this.tbCategoryID.Text);
            string info_XML = krDAO.getXML_CATEGORY_TEXT(categoryID,language);
            string info_category = krDAO.getStr_CATEGORY(categoryID);
            string info_text = krDAO.getStr_CATEGORY_TEXT(categoryID, language);
            this.wbXML.DocumentText = info_XML;
            this.tbCategoryInfo.Text = info_category;
            this.tbTextInfo.Text = info_text;
        }
    }
}
