using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WareHouseMgClient.Utils
{
    public class XmlHelp
    {
        public static Dictionary<string, string> ReadXml(string dllPath) 
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dllPath);
            XmlNode xn = xmlDoc.SelectSingleNode("UserInfo");
            XmlNodeList xnl = xn.ChildNodes;
            var xmlNodeFirst = xnl[0];
            XmlElement xe = (XmlElement)xmlNodeFirst;
            dic.Add("UserName", xe.GetAttribute("UserName"));
            dic.Add("PassWord", xe.GetAttribute("PassWord"));
            dic.Add("IsRemberPW", xe.GetAttribute("IsRemberPW"));
            dic.Add("IsAutoLogin", xe.GetAttribute("IsAutoLogin"));
            return dic;
        }
        public static void WriteXml(string dllPath, string name, string pwd, string remberpw, string autologin) 
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dllPath);
            //获取根节点
            XmlNode RootNode = (XmlNode)xmlDoc.SelectSingleNode("//UserInfo");
            //添加子节点
            XmlElement XmlChild = xmlDoc.CreateElement("User");
            XmlChild.SetAttribute("UserName", name);
            XmlChild.SetAttribute("PassWord", pwd);
            XmlChild.SetAttribute("IsRemberPW", remberpw);
            XmlChild.SetAttribute("IsAutoLogin", autologin);
            RootNode.AppendChild(XmlChild);
            xmlDoc.Save(dllPath);
        }
        public static void CreateXml(string dllPath)
        {
            try
            {
                XmlDocument tDoc = new XmlDocument();
                XmlDeclaration xmlDecl = tDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                tDoc.AppendChild(xmlDecl);
                // 新建根节点
                XmlElement root = tDoc.CreateElement("UserInfo");
                tDoc.AppendChild(root);
                var str = System.IO.Path.GetFileName(dllPath);  //-->BenXHCMS.xml
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = Encoding.UTF8; //默认其实就是 UTF-8 这里记下怎么写
                settings.Indent = true; //需要缩进元素
                settings.IndentChars = "    "; //使用 四个空格 缩进
                XmlWriter writer = XmlWriter.Create(dllPath, settings);
                tDoc.Save(writer);
                writer.Close();
            }
            catch (Exception ex)
            {
                Clib.Logg.Instance.Error(ex.Message);
            }
        }
        public static void DeleteXml(string dllPath) 
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dllPath);
            //获取根节点
            XmlNode root = xmlDoc.SelectSingleNode("UserInfo");
            //获取根节点的孩子数据
            XmlNodeList xnl = xmlDoc.SelectSingleNode("UserInfo").ChildNodes;
            for (int i = 0; i < xnl.Count; i++)
            {
                XmlElement xe = (XmlElement)xnl.Item(i);
                root.RemoveChild(xe);
            }
            xmlDoc.Save(dllPath);
        }
    }
}
