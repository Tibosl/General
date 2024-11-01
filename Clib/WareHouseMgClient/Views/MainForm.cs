using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseMgClient.Model;
using WareHouseMgClient.Utils;
using WareHouseMgClient.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WareHouseMgClient
{
    public partial class MainForm : AntdUI.Window
    {
        protected UserDto _user;
        private static Dictionary<string, EnumMenu.Menus> menuDic = new Dictionary<string, EnumMenu.Menus>
        {
            {"添加用户", EnumMenu.Menus.AddPerson},
            {"修改密码", EnumMenu.Menus.ModifyPassword},
            {"管理用户", EnumMenu.Menus.ManagerPerson},
            {"退出", EnumMenu.Menus.Exit},
            {"货物管理", EnumMenu.Menus.ProManager},
            {"货物入库", EnumMenu.Menus.InStash},
        };
        public MainForm(UserDto userDto)
        {
            InitializeComponent();
            ConfigParam.setConfigParam("IsExist", false);
            _user = userDto;
            this.main_bar.Text = string.Concat("登录用户：", "[", _user.UserName, "]");
        }

        private void menus_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {

            switch (menuDic[e.Value.ToString()])
            {
                case EnumMenu.Menus.AddPerson:
                    DlgCreateUser dlgCreateUser = new DlgCreateUser();
                    if (dlgCreateUser.ShowDialog() == DialogResult.OK)
                    {
                        CustomBox.Show("注册账户成功", "提示");
                        dlgCreateUser.Close();
                        this.panel.Controls.Clear();
                        UserManagerPer newControl = new UserManagerPer(this);
                        this.panel.Controls.Add(newControl);
                        newControl.Dock = DockStyle.Fill;
                    }
                    break;
                case EnumMenu.Menus.ModifyPassword:
                    DlgModifyPwd dlgModifyPwd = new DlgModifyPwd(_user);
                    if (dlgModifyPwd.ShowDialog() == DialogResult.OK)
                    {
                        CustomBox.Show("修改密码成功，请重新登录", "提示");
                        dlgModifyPwd.Close();
                        ConfigParam.setConfigParam("IsExist", true);
                        this.Close();
                    }
                    break;
                case EnumMenu.Menus.ManagerPerson:
                    UserManagerPer per = new UserManagerPer(this);
                    this.panel.Controls?.Clear();
                    this.panel.Controls.Add(per);
                    per.Dock = DockStyle.Fill;
                    break;
                case EnumMenu.Menus.Exit:
                    if (MessageBox.Show("是否退出系统?", "提示",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ConfigParam.setConfigParam("IsExist", true);
                        this.Close();
                    }
                    break;
                case EnumMenu.Menus.ProManager:
                    UserManagerGoods goods = new UserManagerGoods(this);
                    this.panel.Controls?.Clear();
                    this.panel.Controls.Add(goods);
                    goods.Dock = DockStyle.Fill;
                    break;
                case EnumMenu.Menus.InStash:
                    UserManagerInStash inStash = new UserManagerInStash(this);
                    this.panel.Controls?.Clear();
                    this.panel.Controls.Add(inStash);
                    inStash.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }
    }
    public static class EnumMenu
    {
        public enum Menus
        {
            AddPerson,
            ModifyPassword,
            ManagerPerson,
            Exit,
            ProManager,
            InStash
        }
    }
}
