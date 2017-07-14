using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using System.Data.SqlClient;
using System.Data;

namespace readKR
{
    class SqlServerUtils
    {
        public string ConStr = @"Server=(local)\MILESGE;Database=MRCS;Integrated Security=true;";
        public SqlConnection connect;
        private static SqlServerUtils _sqlUtils;
        private SqlServerUtils(){}
        public static SqlServerUtils getInstance()
        {
            if (_sqlUtils == null)
                _sqlUtils = new SqlServerUtils();
            _sqlUtils.sqlConnect();
            return _sqlUtils;
        }
        private void sqlConnect()
        {
            try
            {
                connect = new SqlConnection(ConStr);
                connect.Open();//打开数据连接
            }
            catch (Exception err)
            {
                connect.Close();
                Console.WriteLine(err.Message);
            }
        }
        public void dataConvert()
        {
            int rootID = 20981;//ICLL

        }
        /// <summary>
        /// 在krv_category中填充DATAXML中文字段，DATAXML英文字段，中文标题，中文描述，中文header
        /// </summary>
        public void setKRV_CATEGORY()
        {
            DataSet locMRCS = new DataSet();
            string strSelectTables = "select * from krv_category;select * from krt_category_text;";
            SqlDataAdapter adapter = new SqlDataAdapter(strSelectTables, connect);
            adapter.TableMappings.Add("krv_category", "krv_category");
            adapter.TableMappings.Add("krt_category_text", "krt_category_text");
            adapter.Fill(locMRCS);
            locMRCS.Tables[0].TableName = "krv_category";
            locMRCS.Tables[1].TableName = "krt_category_text";
            foreach (DataRow row in locMRCS.Tables["krv_category"].Rows)
            {
                if (row["locale_key"].ToString() == "zh")
                    continue;
                string text_id = row["category_text_id"].ToString();
                string category_id = row["category_id"].ToString();
                DataRow[] rows_text_en= locMRCS.Tables["krt_category_text"].Select("category_text_id=" + text_id);
                DataRow[] rows_text_zh = locMRCS.Tables["krt_category_text"].Select("locale_key='zh' and category_id=" + category_id);
                if (rows_text_en.Length == 1)
                {
                    row["DATAXML_en"] = rows_text_en[0]["data_xml"].ToString();
                }
                if(rows_text_zh.Length == 1)
                {
                    row["DATAXML_zh"] = rows_text_zh[0]["data_xml"].ToString();
                    row["title_zh"] = rows_text_zh[0]["category_title"].ToString();
                    row["desc_zh"] = rows_text_zh[0]["category_desc"].ToString();
                    row["title_header_zh"] = row["title_zh"].ToString() + " : " + row["desc_zh"].ToString();
                }
            }
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(locMRCS.Tables["krv_category"]);
        }
        /// <summary>
        /// 填充parentGUID
        /// tblName：krt_category or krv_category etc.
        /// (含有category_id 和 parent_category_id 和 guid 和 parent_guid 字段)
        /// </summary>
        /// <param name="tblName"></param>
        public void set_parentGUID(string tblName)
        {
            DataSet locMRCS = new DataSet();            
            SqlDataAdapter adapter = new SqlDataAdapter("select * from " + tblName, connect);
            adapter.Fill(locMRCS, tblName);
            foreach (DataRow row_parent in locMRCS.Tables[tblName].Rows)
            {
                string category_id = row_parent["category_id"].ToString();
                DataRow[] rows = locMRCS.Tables[tblName].Select("parent_category_id=" + category_id);
                foreach (DataRow row in rows)
                    row["PARENT_GUID"] = row_parent["GUID"];
            }
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(locMRCS, tblName);
        }
        public KRT_CATEGORY_TEXT get_CATEGORY_TEXT_byID(int categoryID, string language)
        {
            DataTable dt = new DataTable();
            KRT_CATEGORY_TEXT category_text = null;
            DataRow row = null;
            string sql = "select * from KRT_CATEGORY_TEXT where CATEGORY_ID=" + categoryID + " and LOCALE_KEY='" + language + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                category_text = new KRT_CATEGORY_TEXT(row);
            }
            return category_text;
        }
        public KRV_CATEGORY get_KRV_CATEGORY_byID(int categoryID, string language)
        {
            DataTable dt = new DataTable();
            KRV_CATEGORY category = null;
            DataRow row = null;
            string sql = "select * from KRV_CATEGORY where CATEGORY_ID=" + categoryID + " and LOCALE_KEY='" + language + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                category = new KRV_CATEGORY(row);
            }
            return category;
        }
        public KRT_CATEGORY get_CATEGORY_byID(int categoryID)
        {
            DataTable dt = new DataTable();
            KRT_CATEGORY category = null;
            DataRow row = null;
            string sql = "select * from KRT_CATEGORY where CATEGORY_ID=" + categoryID;
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                category = new KRT_CATEGORY(row);
            }
            return category;
        }
        public void db3ToSqlServer(string tblName)
        {            
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = connect;
            mycmd.CommandType = CommandType.Text;
            mycmd.CommandText = "select * from " + tblName;
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(mycmd);
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, tblName);
            DataTable myTable = myDataSet.Tables[tblName];
            KrDAO krDAO=KrDAO.getKrDAO();
            DataSet dsKR = new DataSet();
            dsKR=  krDAO.getDataSet();
            DataTable dtKR = dsKR.Tables[tblName];          
            Console.WriteLine(myTable.Rows.Count);
            Console.WriteLine(dsKR.Tables[tblName].Rows.Count);            
            foreach (DataRow row in dtKR.Rows)
            {
                DataRow r = myTable.NewRow();
                r.ItemArray = (object[])row.ItemArray.Clone();
                myTable.Rows.Add(r);
            }
            Console.Write(myTable.Rows.Count);
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, tblName);
            connect.Close();
        }
    }
}
