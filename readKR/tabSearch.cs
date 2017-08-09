using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataModels;
using System.Windows.Forms;

namespace readKR
{
    public partial class frmMain
    {
        private void btntitlesearch_Click(object sender, EventArgs e)
        {
            string keyword = this.tbsearchword.Text;
            DataTable dt= getsearchResult(keyword);
            this.lblCount.Text = string.Format("总数: {0}",dt.Rows.Count);
            this.dgvSearch.DataSource=dt;
            dgvSearch.Columns["CATEGORY_ID"].Visible = false;
            dgvSearch.Columns["CONTENT_HEADER"].HeaderText = "Path";
            dgvSearch.Columns["CATEGORY_HEADER"].HeaderText = "Title";
            dgvSearch.AutoSizeColumnsMode= System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearch.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgvSearch.ReadOnly = true;
        }
        private DataTable getsearchResult(string keyword)
        {
            string sql = string.Format("select  CATEGORY_ID,CONTENT_HEADER,CATEGORY_HEADER from KRV_CATEGORY where LOCALE_KEY='en'  and IS_VISIBLE=1 and(CATEGORY_HEADER like '%{0}%' or CATEGORY_HEADER like '%{0}%') and CATEGORY_TREE like '0000.%' order by CATEGORY_TREE", keyword);
            DataTable dt= krDAO.doSelect(sql);          
            return dt;
        }
        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int categoryID = Convert.ToInt32(this.dgvSearch[0, e.RowIndex].Value);
            showContent(categoryID);
            this.tabs.SelectTab("tabTreeView");
        }
    }
}
