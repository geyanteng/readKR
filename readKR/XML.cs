using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using DataModels;
namespace readKR
{
    public static class XML
    {
        static public void SaveToXml(TreeView treeView1, string path)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xml = new XDocument(dec);
            XElement root = new XElement("Tree");
            foreach (TreeNode node in treeView1.Nodes)
            {
                XElement e = CreateElements(node);
                root.Add(e);
            }
            xml.Add(root);
            xml.Save(path);
        }
        static private XElement CreateElements(TreeNode node)
        {
            XElement root = CreateElement(node);
            foreach (TreeNode n in node.Nodes)
            {
                XElement e = CreateElements(n);
                root.Add(e);
            }
            return root;
        }
        static private XElement CreateElement(TreeNode node)
        {
            return new XElement("Node",
                new XAttribute("Name", node.Name),
                new XAttribute("Text", node.Text)
                );
        }
        static public void SaveToXml(Tree<KRV_CATEGORY> tree, string path)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xml = new XDocument(dec);
            XElement root = new XElement("Tree");
            XElement rootnode = CreateElement(tree);
            root.Add(rootnode);
            foreach (Tree<KRV_CATEGORY> node in tree.Nodes)
            {
                XElement e = CreateElements(node);
                rootnode.Add(e);
            }
            xml.Add(root);
            xml.Save(path);
        }
        static private XElement CreateElements(Tree<KRV_CATEGORY> node)
        {
            XElement root = CreateElement(node);
            foreach (Tree<KRV_CATEGORY> n in node.Nodes)
            {
                XElement e = CreateElements(n);
                root.Add(e);
            }
            return root;
        }
        static private XElement CreateElement(Tree<KRV_CATEGORY> node)
        {
            return new XElement("Node",
                new XAttribute("ID", node.Data.CATEGORY_ID),
                new XAttribute("LocaleKey", node.Data.LOCALE_KEY),
                new XAttribute("ContentCode", node.Data.CONTENT_CODE),
                new XAttribute("Title", node.Data.CATEGORY_HEADER),
                new XAttribute("NodeType", node.Data.NODE_TYPE)
                );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="XMLpath"></param>
        /// <param name="nodes">treeView1.Nodes</param>
        /// <returns></returns>
        static public void loadXML(string XMLpath, TreeView treeview)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLpath);
            RecursionTreeControl(doc.DocumentElement, treeview.Nodes);
        }
        static public void RecursionTreeControl(XmlNode xmlNode, TreeNodeCollection nodes)
        {
            foreach (XmlNode node in xmlNode.ChildNodes)//循环遍历当前元素的子元素集合
            {
                TreeNode new_child = new TreeNode();//定义一个TreeNode节点对象
                new_child.Name = node.Attributes["ID"].Value;
                new_child.Text = node.Attributes["Title"].Value;
                nodes.Add(new_child);//向当前TreeNodeCollection集合中添加当前节点
                RecursionTreeControl(node, new_child.Nodes);//调用本方法进行递归
            }
        }
    }
}
