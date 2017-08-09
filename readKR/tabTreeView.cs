using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataModels;
using System.Windows.Forms;
using System.Drawing;
//20979
namespace readKR
{
    public partial class frmMain
    {
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                int category_id = Convert.ToInt32(e.Node.Name);
                showContent(category_id);
            }
        }
        private Point wbContentLocation = new Point();
        private int wbContentHeight;
        public void showContent(int category_id)
        {
            string text = krDAO.getXML_CATEGORY_TEXT(category_id, "en");
            string toDel1 = "<IMG alt=\"\" src=\"http://krcon.krs.co.kr/images/icon/link.gif\">";
            string toDel2 = "<IMG alt=\"\" src=\"/images/icon/link.gif\">";
            string toDel3 = "<IMG style=\"BORDER-TOP: 0px solid; BORDER-RIGHT: 0px solid; BORDER-BOTTOM: 0px solid; BORDER-LEFT: 0px solid\" alt=Go! src=\"/images/icon/link.gif?fullpathlink=content\">";
            text = text.Replace(toDel1, "").Replace(toDel2, "").Replace(toDel3, "");
            this.wbContent.DocumentText = text;
            string sql_info = string.Format("Select * from krv_category where category_id={0} and locale_key='en'", category_id);
            KRV_CATEGORY krv_category = new KRV_CATEGORY(krDAO.doSelect(sql_info).Rows[0]);
            if (krv_category.IS_HEADER == false)
            {
                this.tbScope.Visible = false;
                this.wbContent.Location= new Point(this.wbContent.Location.X, this.tbScope.Location.Y);
                wbContent.Height = this.treeView1.Height;
            }
            else
            {
                this.tbScope.Visible = true;
                this.wbContent.Location = wbContentLocation;
                this.wbContent.Height = wbContentHeight;
            }
            this.tbScope.Text = makeScope.getScope(krv_category);
        }
        public void treeView()//从数据库文件中获取全部目录，存到xml里
        {
            List<int> IDlist = new List<int> {20979,20980,
                12908,12920,33380,20982,55686,50261,50414,25314,25308,20981,25309,65668,59937,51540,49319,3550,3525,25315,49370
                ,58893,25310,57809,56366,65812,59147,49362,4070,13177,20984,20999,20987,20988,20985,51529,51530,51531,51532,51533,51534};
            for (int i = 2; i < IDlist.Count; i++)
            {
                int rootID = IDlist[i];
                string sql_info = string.Format("Select * from krv_category where category_id={0} and locale_key='en'", rootID);
                List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql_info));
                Tree<KRV_CATEGORY> roottree = new Tree<KRV_CATEGORY> { Data = list[0] };
                getTree(roottree);
                TreeNode nodeview0 = new TreeNode();
                treeToTreeView(roottree, nodeview0);//将树结构复制转为可供显示的TreeView控件的结构 
                this.treeView1.Nodes.Add(nodeview0);
                XML.SaveToXml(roottree, string.Format("../../TreeXml{0}.xml",i));
            }
        }      
        public void getTree(Tree<KRV_CATEGORY> root)
        {
            if (root == null)
                return;
            Tree<KRV_CATEGORY> tree = new Tree<KRV_CATEGORY>();
            Tree<KRV_CATEGORY> root_parent = root.Parent;
            KRV_CATEGORY krv_category = root.Data;
            switch (krv_category.NODE_TYPE)
            {
                case 0:
                    tree = getNormalTree(krv_category);
                    break;
                case 1:
                    tree = getLinkNodeTree(krv_category);
                    getTree(tree);
                    break;
                case 2:
                    tree = getIntegratedTree(krv_category);
                    break;
                case 3:
                    tree = getChapterYearTree(krv_category);
                    break;
            }
            root.Data = tree.Data;
            foreach (var node in tree.Nodes)
            {
                root.AddNode(node); 
                if(krv_category.NODE_TYPE!=2)           
                    getTree(node);
            }          
        }
        public Tree<KRV_CATEGORY> getNormalTree(KRV_CATEGORY krv_category)
        {
            string sql = string.Format("select * from krv_category where parent_category_id={0} and locale_key='en' order by category_order"
                , krv_category.CATEGORY_ID);
            List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql));
            Tree<KRV_CATEGORY> root = new Tree<KRV_CATEGORY>();
            root.Data = krv_category;
            foreach (var item in list)
            {
                Tree<KRV_CATEGORY> node = new Tree<KRV_CATEGORY> { Data = item };
                root.AddNode(node);
            }
            return root;
        }
        public Tree<KRV_CATEGORY> getLinkNodeTree(KRV_CATEGORY krv_category)
        {
            string sql = string.Format("select * from krv_category where category_id={0} and locale_key='en'", krv_category.LINK_CATEGORY);
            List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql));
            Tree<KRV_CATEGORY> node = new Tree<KRV_CATEGORY>();
            if (list.Count == 1)
                node.Data = list[0];
            return node;
        }
        public Tree<KRV_CATEGORY> getChapterYearTree(KRV_CATEGORY krv_category)
        {
            string sql = string.Format("select * from krv_category where content_code like '{0}' and locale_key='en' order by content_code",
                krv_category.CHAPTER_YEAR_ROOT);
            List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql));
            Tree<KRV_CATEGORY> tree = new Tree<KRV_CATEGORY> { Data = krv_category };
            foreach (var item in list)
            {
                item.CATEGORY_HEADER = item.CONTENT_HEADER;
                Tree<KRV_CATEGORY> node = new Tree<KRV_CATEGORY> { Data = item };
                tree.AddNode(node);
            }
            return tree;
        }
        //例如综合文本的II-2章的content_code=e.s.co.a01.022, 得到以该目录为根节点的树结构
        public Tree<KRV_CATEGORY> getIntegratedTree(KRV_CATEGORY krv_category)
        {
            string content_code = krv_category.CONTENT_CODE;
            string queryCode = krv_category.INTEGRATION_ROOT;// convertCode(content_code);//转化为e.s.__.a01.022形式
            string sql = string.Format("select * from krv_category where content_code like '{0}.%' and locale_key='en' and IS_DYNAMIC_TREE=1  and DATE_BUILD_H is null", queryCode);
            List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql));
            list.Sort(new Comparison<KRV_CATEGORY>(CompareKRVCATEGORY));//对获取的综合文本列表进行排序
            list = clearList(list);  //若某目录下有多个年份的子条目，则该目录也会有多年份的重复，需要清除掉重复的目录条目，保留最新的年份的目录记录。
            string sql1 = string.Format("select * from krv_category where content_code ='{0}' and locale_key='en'", content_code);//添加父节点到列表的首位
            DataTable tbl1 = krDAO.doSelect(sql1);
            if (tbl1.Rows.Count == 1)
                list.Insert(0, new KRV_CATEGORY(tbl1.Rows[0]));
            getTitle(ref list);
            Tree<KRV_CATEGORY> tree = listToTree(list);//将排好序的列表，转化为树结构
            return tree;
        }
        //字符串排序方式，需要去掉content_code中间年份项，以按条目顺序排序。
        //e.s.b0.a01.022.0400,去掉表示年份的b0,变为e.s.__.a01.022.0400
        public static string convertCode(string code)
        {
            string[] codepath = code.Split(new char[] { '.' });
            codepath[2] = "__";
            return string.Join(".", codepath);
        }
        //对获取的综合文本列表进行排序的方式
        private static int CompareKRVCATEGORY(KRV_CATEGORY x, KRV_CATEGORY y)
        {
            string comparecode_x = convertCode(x.CONTENT_CODE);//字符串排序方式，需要去掉content_code中间年份项，以按条目顺序排序。
            string comparecode_y = convertCode(y.CONTENT_CODE);
            return string.Compare(comparecode_x, comparecode_y);
        }
        //若某目录下有多个年份的子条目，则该目录也会有多年份的重复，需要清除掉重复的目录条目，保留最新的年份的目录记录。
        public List<KRV_CATEGORY> clearList(List<KRV_CATEGORY> list)
        {

            List<KRV_CATEGORY> newlist = new List<KRV_CATEGORY>();
            List<string> codes = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                string newcode = convertCode(list[i].CONTENT_CODE);

                if (list[i].IS_LEAF == false && codes.Contains(newcode))
                    newlist.Add(list[i]);
                if (!codes.Contains(newcode))
                    codes.Add(newcode);
            }
            foreach (var item in newlist)
                list.Remove(item);
            return list;
        }
        //获得用于在目录树中显示的标题
        public void getTitle(ref List<KRV_CATEGORY> list)
        {
            foreach (var item in list)
            {
                if (item.IS_LEAF == true)
                    if (item.CATEGORY_DESC != null)
                        item.CATEGORY_HEADER = string.Format("{0} ({1}) : {2}", item.CATEGORY_TITLE, item.TREE_GROUP_TITLE, item.CATEGORY_DESC);
                    else
                        item.CATEGORY_HEADER = string.Format("{0} ({1})", item.CATEGORY_TITLE, item.TREE_GROUP_TITLE);
            }
        }
        //将排好序的列表，转化为树结构
        public Tree<KRV_CATEGORY> listToTree(List<KRV_CATEGORY> list)
        {
            Tree<KRV_CATEGORY> root = null;
            Dictionary<string, Tree<KRV_CATEGORY>> dic = new Dictionary<string, Tree<KRV_CATEGORY>>();
            foreach (KRV_CATEGORY item in list)
            {
                string CONTENT_CODE = convertCode(item.CONTENT_CODE);
                string[] contentPath = CONTENT_CODE.Split(new char[] { '.' });
                string parentContentTree = string.Join(".", contentPath, 0, contentPath.Length - 1);
                Tree<KRV_CATEGORY> treeNode = new Tree<KRV_CATEGORY> { Data = item };
                if (dic.ContainsKey(parentContentTree))
                {
                    dic[parentContentTree].AddNode(treeNode);
                }
                else if (root == null)
                {
                    root = treeNode;
                }
                else
                {
                    root.AddNode(treeNode);
                }
                if (!dic.ContainsKey(CONTENT_CODE))
                {
                    dic.Add(CONTENT_CODE, treeNode);
                }
            }
            return root;
        }
        public List<KRV_CATEGORY> tableToList(DataTable tbl)
        {
            List<KRV_CATEGORY> list = new List<KRV_CATEGORY>();
            foreach (DataRow row in tbl.Rows)
            {
                KRV_CATEGORY krv_category = new KRV_CATEGORY(row);
                list.Add(krv_category);
            }
            return list;
        }
        //将树结构复制转为可供显示的TreeView控件的结构 
        public void treeToTreeView(Tree<KRV_CATEGORY> tree, TreeNode nodeview)
        {
            if (tree == null)
                return;
            string show = tree.Data.CATEGORY_HEADER;
            nodeview.Text = show;
            nodeview.Name = tree.Data.CATEGORY_ID.ToString();
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                TreeNode subnodeview = new TreeNode();
                nodeview.Nodes.Add(subnodeview);
            }
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                treeToTreeView(tree.Nodes[i], nodeview.Nodes[i]);
            }
        }
        //public void treeview()
        //{
        //    int rootID = 20979;
        //    string sql_info = string.Format("Select * from krv_category where category_id={0} and locale_key='en'", rootID);
        //    List<KRV_CATEGORY> list0 = tableToList(krDAO.doSelect(sql_info));
        //    TreeNode rootnodeview = new TreeNode { Name = rootID.ToString(), Text = list0[0].CATEGORY_HEADER };
        //    this.treeView1.Nodes.Add(rootnodeview);
        //    string sql = string.Format("Select * from krv_category where parent_category_id={0} and locale_key='en' order by category_order", rootID);
        //    List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql));
        //    foreach (var item in list)
        //    {
        //        TreeNode subNode = new TreeNode { Name = item.CATEGORY_ID.ToString(), Text = item.CATEGORY_HEADER };
        //        rootnodeview.Nodes.Add(subNode);
        //    }
        //}
        //public void treeViewByClick(int rootID, TreeNode nodeview)
        //{
        //    foreach (TreeNode node in nodeview.Nodes)
        //    {
        //        string sql = string.Format("Select * from krv_category where parent_category_id={0} and locale_key='en' order by category_order", node.Name);
        //        List<KRV_CATEGORY> list = tableToList(krDAO.doSelect(sql));
        //        foreach (var item in list)
        //        {
        //            TreeNode subnodeview = new TreeNode { Text = item.CATEGORY_HEADER, Name = item.CATEGORY_ID.ToString() };
        //            node.Nodes.Add(subnodeview);
        //        }
        //    }
        //}
    }
}
