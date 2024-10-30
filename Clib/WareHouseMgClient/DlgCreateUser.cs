using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseMgClient.Service;
using WareHouseMgClient.Utils;

namespace WareHouseMgClient
{
    public partial class DlgCreateUser : AntdUI.BaseForm
    {
        UserApi _api = new UserApi();
        public DlgCreateUser()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string name = this.Input_name.Text.Trim().ToString();
            string password = this.Input_pwd.Text.Trim().ToString();
            string repeat = this.Input_repeatName.Text.Trim().ToString();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeat))
            {
                CustomBox.Show("必填项数据为空", "提示");
                return;
            }
            if (password != repeat) 
            {
                CustomBox.Show("两次密码输入不一致","提示");
                return;
            }
            string[] columns = { "u_id", "username", "password" ,"age","info","createtime","modifytime","sex"};
            object[] values = { Guid.NewGuid().ToString("N"), name, password,28,"超级管理员",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),1 };
            if (_api.insertUserInfo(columns, values)) 
            {
                DialogResult = DialogResult.OK;
                return;
            }
            CustomBox.Show("创建账户失败","提示");
        }
    }
}
