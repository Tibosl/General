using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseMgClient.Model;
using WareHouseMgClient.Utils;

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
        };
        public MainForm(UserDto userDto)
        {
            InitializeComponent();
            _user = userDto;
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
                    }
                    break;
                case EnumMenu.Menus.ModifyPassword:
                    break;
                case EnumMenu.Menus.ManagerPerson:
                    break;
                case EnumMenu.Menus.Exit:
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
            Exit
        }
    }
}
