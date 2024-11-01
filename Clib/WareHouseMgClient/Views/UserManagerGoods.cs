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
using WareHouseMgClient.Views;

namespace WareHouseMgClient
{
    public partial class UserManagerGoods : UserControl
    {
        private GoodApi api = new GoodApi();
        private AntList<GoodsDto> antList = new AntList<GoodsDto>();
        private AntdUI.Window _form;
        public UserManagerGoods(AntdUI.Window form)
        {
            _form = form;
            InitializeComponent();
            InitData();
            InitControls();
            dataTableUsers.CellButtonClick += DataTableUsers_CellButtonClick;
        }

        private void DataTableUsers_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var buttontext = e.Btn.Text;

            if (e.Record is GoodsDto good)
            {
                switch (buttontext)
                {
                    case "编辑":
                        var form = new UserGoodEdit(_form, good) { Size = new Size(400, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(_form, form)
                        {
                            OnLoad = () =>
                            {

                            },
                            OnClose = () =>
                            {
                                if (form.submit)
                                {
                                    InitData();
                                    AntdUI.Message.success(_form, "修改数据成功", autoClose: 2);
                                }
                            }
                        });
                        break;
                    case "删除":
                        if (Modal.open(_form, "是否删除此数据？", "提示", TType.Info) == DialogResult.OK)
                        {
                            good.IsDelete = 1;
                            api.DeleteGood(good);
                            antList.Remove(good);
                            AntdUI.Message.success(_form, "删除数据成功", autoClose: 2);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void InitControls()
        {
            dataTableUsers.Columns = new ColumnCollection
            {
                new ColumnCheck("Selected")
                {
                    Fixed = true
                },
                new Column("GoodId", "货物编码",ColumnAlign.Center),
                new Column("GoodName", "货物名称",ColumnAlign.Center),
                new Column("GoodTime", "货物入库时间",ColumnAlign.Center),
                new ColumnSwitch("Enabled", "是否启用", ColumnAlign.Center){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        //执行耗时操作
                        Thread.Sleep(1000);
                        int enabled = value ? 0 : 1;
                        if(record is GoodsDto g)
                        {
                            api.IsEnabledGoods(enabled, g.GId);
                            InitData();
                        }
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

        private void InitData()
        {
            antList = new AntList<GoodsDto>();
            var goodsDt = api.getGoods();
            foreach (DataRow item in goodsDt.Rows)
            {
                antList.Add(new GoodsDto
                {
                    Selected = false,
                    Enabled = Convert.ToInt32(item["enabled"]) == 0,
                    CellBadge = Convert.ToInt32(item["enabled"]) == 0 ? new CellBadge(TState.Success,"启用中") : new CellBadge(TState.Error, "禁用中"),
                    CellLinks = new CellLink[]
                    {
                        new CellButton(Guid.NewGuid().ToString(),"编辑",TTypeMini.Primary),
                        new CellButton(Guid.NewGuid().ToString(),"删除",TTypeMini.Error)
                    },
                    GId = item["g_id"].ToString(),
                    GoodId = item["goods_Id"].ToString(),
                    GoodName = item["goods_name"].ToString(),
                    GoodTime = item["goods_time"].ToString(),
                    IsDelete = Convert.ToInt32(item["isdelete"])
                });
            }
            this.dataTableUsers.Binding<GoodsDto>(antList);
        }
    }
}
