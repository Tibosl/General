using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseMgClient.Model;
using WareHouseMgClient.Service;
using WareHouseMgClient.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WareHouseMgClient.Views
{
    public partial class UserManagerPer : UserControl
    {
        private UserApi api = new UserApi();
        private AntList<UserDto> antList = new AntList<UserDto>();
        private AntdUI.Window _form;
        public UserManagerPer(AntdUI.Window form)
        {
            InitializeComponent();
            _form = form;
            InitTableColumns();
            InitData();
            dataTableUsers.CellButtonClick += DataTableUsers_CellButtonClick; ;
        }

        private void DataTableUsers_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var buttontext = e.Btn.Text;

            if (e.Record is UserDto user)
            {
                switch (buttontext)
                {
                    case "编辑":
                        var form = new UserUserEdit(_form, user) { Size = new Size(400, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(_form, form)
                        {
                            OnLoad = () =>
                            {
                                
                            },
                            OnClose = () =>
                            {
                                if (form.submit) 
                                {
                                    AntdUI.Message.success(_form, "修改数据成功", autoClose: 2);
                                }
                            }
                        });
                        break;
                    case "删除":
                        if (Modal.open(_form, "是否删除此数据？", "提示",TType.Info) == DialogResult.OK)
                        {
                            api.DeleteUser(user);
                            antList.Remove(user);
                            AntdUI.Message.success(_form, "删除数据成功", autoClose: 2);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void InitData()
        {
            foreach (UserDto item in GetUsers())
            {
                item.Enabled = true;
                item.CellBadge = new CellBadge(TState.Success, "启用中");
                item.CellLinks = new CellLink[]
                {
                    new CellButton(Guid.NewGuid().ToString(),"编辑",TTypeMini.Primary),
                    new CellButton(Guid.NewGuid().ToString(),"删除",TTypeMini.Error)
                };
                if (item.Sex == 0)
                {
                    item.SexStr = "女";
                }
                else 
                {
                    item.SexStr = "男";
                }
                antList.Add(item);
            }
            dataTableUsers.Binding<UserDto>(antList);
        }

        private List<UserDto> GetUsers()
        {
            DataTable userDataTable = api.getUserInfo();
            return DataTableHelp.DataTableToList<UserDto>(userDataTable);
        }

        private void InitTableColumns()
        {
            dataTableUsers.Columns = new ColumnCollection()
            {
                new ColumnCheck("Selected")
                {
                    Fixed = true
                },
                new Column("UserName", "姓名",ColumnAlign.Center),
                new Column("PassWord", "密码",ColumnAlign.Center),
                new Column("Age", "年龄",ColumnAlign.Center),
                new Column("Info", "类别",ColumnAlign.Center),
                new Column("SexStr", "性别",ColumnAlign.Center),
                new ColumnSwitch("Enabled", "是否启用", ColumnAlign.Center){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        //执行耗时操作
                        Thread.Sleep(1000);
                        return value;
                    }
                },
                new Column("CellBadge", "状态",ColumnAlign.Center),
                new Column("CellLinks", "操作", ColumnAlign.Center)
                {
                    Fixed = true
                },
            };
        }
    }
}
