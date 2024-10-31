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

namespace WareHouseMgClient.Views
{
    public partial class DlgUserEdit : UserControl
    {
        private AntdUI.Window window;
        private UserDto user;
        private UserApi api = new UserApi();
        public bool submit;
        public DlgUserEdit(AntdUI.Window _window, UserDto _user)
        {
            this.window = _window;
            user = _user;
            InitializeComponent();
            InitData();
            selectSex.Items.AddRange(new string[] { "男","女"});
            selectSex.List = true;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            input_name.Status = AntdUI.TType.None;
            //检查输入内容
            if (String.IsNullOrEmpty(input_name.Text))
            {
                input_name.Status = AntdUI.TType.Error;
                AntdUI.Message.warn(window, "姓名不能为空！", autoClose: 3);
                return;
            }
            user.UserName = input_name.Text;
            user.PassWord = input_pwd.Text;
            user.Age = (int)input_age.Value;
            user.Info = input_info.Text;
            user.Sex = selectSex.Text == "女" ? 0 : 1;
            if (api.UpdateUser(user)) 
            {
                submit = true;
            }
            this.Dispose();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            submit = false;
            this.Dispose();
        }
        private void InitData()
        {
            input_name.Text = user.UserName;
            input_pwd.Text = user.PassWord;
            input_age.Value = user.Age;
            input_info.Text = user.Info;
            selectSex.Text = user.Sex == 0 ? "女" : "男";
        }
    }
}
