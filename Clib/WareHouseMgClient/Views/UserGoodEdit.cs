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
using WareHouseMgClient.Interface;
using WareHouseMgClient.Model;
using WareHouseMgClient.Service;

namespace WareHouseMgClient.Views
{
    public partial class UserGoodEdit : UserControl
    {
        private AntdUI.Window window;
        public bool submit;
        private GoodsDto _good;
        private GoodApi api = new GoodApi();
        public UserGoodEdit(AntdUI.Window _window, GoodsDto good)
        {
            InitializeComponent();
            _good = good;
            InitData();
        }

        private void InitData()
        {
            this.input_goodCode.Text = _good.GoodId;
            this.input_goodName.Text = _good.GoodName;
            this.input_goodTime.Text = _good.GoodTime;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            input_goodCode.Status = AntdUI.TType.None;
            input_goodName.Status = AntdUI.TType.None;
            input_goodTime.Status = AntdUI.TType.None;
            CheckValue(input_goodCode,"货物编码不能为空");
            CheckValue(input_goodName,"货物名称不能为空");
            CheckValue(input_goodTime,"货物入库时间不能为空");
            _good.GoodId = input_goodCode.Text;
            _good.GoodName = input_goodName.Text;
            _good.GoodTime = input_goodTime.Text;
            if (api.UpdateGood(_good))
            {
                submit = true;
            }
            this.Dispose();
        }
        private void CheckValue(Input input,string info) 
        {
            //检查输入内容
            if (string.IsNullOrEmpty(input.Text))
            {
                input_goodCode.Status = AntdUI.TType.Error;
                AntdUI.Message.warn(window, info, autoClose: 3);
                return;
            }
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            submit = false;
            this.Dispose();
        }
    }
}
