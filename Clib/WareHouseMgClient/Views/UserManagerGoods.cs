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
            var goodsDt = api.getGoods();
            foreach (DataRow item in goodsDt.Rows)
            {
                antList.Add(new GoodsDto
                {
                    Selected = false,
                    Enabled = true,
                    CellBadge = new CellBadge(TState.Success, "启用中"),
                    CellLinks = new CellLink[]
                    {
                        new CellButton(Guid.NewGuid().ToString(),"编辑",TTypeMini.Primary),
                        new CellButton(Guid.NewGuid().ToString(),"删除",TTypeMini.Error)
                    },
                    GId = item["g_id"].ToString(),
                    GoodId = item["goods_Id"].ToString(),
                    GoodName = item["goods_name"].ToString(),
                    GoodTime = item["goods_time"].ToString(),
                });
            }   
            this.dataTableUsers.Binding<GoodsDto>(antList);
        }
    }
}
