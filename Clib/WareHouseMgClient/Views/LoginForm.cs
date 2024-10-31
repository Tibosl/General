using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WareHouseMgClient.Model;
using WareHouseMgClient.Service;
using WareHouseMgClient.Utils;

namespace WareHouseMgClient
{
    public partial class LoginForm : AntdUI.Window
    {
        UserApi _uapi = new UserApi();
        private UserDto userDto;
        public LoginForm()
        {
            InitializeComponent();
            GetConfigInfo();
        }

        private void GetConfigInfo()
        {
            if (!File.Exists(Program.dllPath)) return;
            var dic = XmlHelp.ReadXml(Program.dllPath);
            this.Input_name.Text = dic["UserName"];
            this.Input_pwd.Text = dic["PassWord"];
            this.cbx_pwd.Checked = Convert.ToBoolean(dic["IsRemberPW"]);
            this.cbx_auto.Checked = Convert.ToBoolean(dic["IsAutoLogin"]);
        }

        public UserDto getUser() 
        {
            return userDto;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var account = this.Input_name.Text.Trim().ToString();
            var password = this.Input_pwd.Text.Trim().ToString();
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password)) 
            {
                CustomBox.Show("请输入账号或密码", "提示");
                return;
            }
            var rest = _uapi.getUserInfo(account, password);
            if (rest.Rows.Count == 0)
            {
                CustomBox.Show("账号或密码错误", "提示");
                return;
            }
            BtnLogin.Spin(() => 
            {
                var userList = DataTableHelp.DataTableToList<UserDto>(rest);
                if (userList.Count == 0)
                {
                    CustomBox.Show("系统中找不到该用户", "提示");
                    return;
                }
                userDto = userList?.FirstOrDefault();
                //写入配置文件
                if (cbx_pwd.Checked)
                {
                    if (!File.Exists(Program.dllPath))
                    {
                        CreateXml(Program.dllPath);
                    }
                    XmlHelp.DeleteXml(Program.dllPath);
                    WriteXml(Program.dllPath);
                }
                Thread.Sleep(1000);
                DialogResult = DialogResult.OK;
            }, () => 
            {
            });
        }

        private void WriteXml(string dllPath)
        {
            var name = this.Input_name.Text.Trim().ToString();
            var pwd = this.Input_pwd.Text.Trim().ToString();
            var remberPW = this.cbx_pwd.Checked.ToString();
            var autoLogin = this.cbx_auto.Checked.ToString();
            XmlHelp.WriteXml(dllPath,name,pwd,remberPW,autoLogin);
        }

        private void CreateXml(string dllPath)
        {
            XmlHelp.CreateXml(dllPath);
        }

        private void cbx_auto_CheckedChanged(object sender, BoolEventArgs e)
        {
            if (cbx_auto.Checked)
            {
                this.cbx_pwd.Checked = true;
            }
        }
    }
}
