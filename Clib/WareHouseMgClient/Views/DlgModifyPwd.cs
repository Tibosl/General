using AntdUI;
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
using WareHouseMgClient.Service;
using WareHouseMgClient.Utils;

namespace WareHouseMgClient.Views
{
    public partial class DlgModifyPwd : Window
    {
        private UserDto _user;
        private UserApi _api = new UserApi();
        public DlgModifyPwd(UserDto user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var oldPwd = this.Input_old_pwd.Text.Trim().ToString();
            var newPwd = this.Input_new_pwd.Text.Trim().ToString();
            var repeatPwd = this.Input_repeat_pwd.Text.Trim().ToString();
            if (string.IsNullOrEmpty(oldPwd) || string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(repeatPwd)) 
            {
                CustomBox.Show( "必填项数据为空，请填写后重试", "提示");
                return;
            }
            if (!oldPwd.Equals(_user.PassWord))
            {
                CustomBox.Show( "旧密码输入错误", "提示");
                return;
            }
            if (!newPwd.Equals(repeatPwd)) 
            {
                CustomBox.Show( "新密码与重复密码两次输入不一致", "提示");
                return;
            }
            if (_user == null) 
            {
                CustomBox.Show( "未找到当前登录用户信息", "提示");
                return;
            }
            _user.PassWord = newPwd;
            if (_api.modifyPwd(_user)) DialogResult = DialogResult.OK;
        }

        private void BtnShowpw1_Click(object sender, EventArgs e)
        {
            ShowOrHidenPwd(BtnShowpw1,Input_old_pwd);
        }

        private void BtnShowpw2_Click(object sender, EventArgs e)
        {
            ShowOrHidenPwd(BtnShowpw2, Input_new_pwd);
        }

        private void BtnShowpw3_Click(object sender, EventArgs e)
        {
            ShowOrHidenPwd(BtnShowpw3, Input_repeat_pwd);
        }
        private void ShowOrHidenPwd(AntdUI.Button btn, AntdUI.Input input)
        {
            if (input.PasswordChar.Equals('*'))
            {
                input.PasswordChar = '\0';
                btn.Icon = Properties.Resources.隐藏密码;
            }
            else
            {
                input.PasswordChar = '*';
                btn.Icon = Properties.Resources.显示密码;
            }
        }
    }
}
