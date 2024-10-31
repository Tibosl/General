using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using WareHouseMgClient.Model;
using WareHouseMgClient.Service;
using WareHouseMgClient.Utils;

namespace WareHouseMgClient
{
    internal static class Program
    {
        public readonly static string dllPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar + "UserInfo.xml";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var connect = DBConnect.getConn();
            if (connect != null)
            {
                LoginForm loginForm = new LoginForm();
                if (!File.Exists(dllPath)) return;
                var dic = XmlHelp.ReadXml(dllPath);
                if (dic["IsAutoLogin"] != "True")
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        var user = loginForm.getUser();
                        loginForm.Close();
                        Application.Run(new MainForm(user));
                        //退出或者修改密码
                        ShowForm();
                    }
                    else
                    {
                        loginForm.Dispose();
                    }
                }
                else 
                {
                    var rest = new UserApi().getUserInfo(dic["UserName"], dic["PassWord"]);
                    var userList = DataTableHelp.DataTableToList<UserDto>(rest);
                    Application.Run(new MainForm(userList?.FirstOrDefault()));
                }
            }
            DBConnect.ConnectClose();
        }
        private static void ShowForm() 
        {
            if (ConfigParam.getConfigParam())
            {
                LoginForm lgform = new LoginForm();
                if (lgform.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(lgform.getUser()));
                    ShowForm();
                }
                else
                {
                    lgform.Dispose();
                }
            }
        }
    }
}
