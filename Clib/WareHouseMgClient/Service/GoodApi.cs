using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMgClient.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WareHouseMgClient.Utils;
using WareHouseMgClient.Model;

namespace WareHouseMgClient.Service
{
    public class GoodApi : IGood
    {
        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <returns></returns>
        public DataTable getGoods()
        {
            string sql = "select * from w_goods where isdelete = 0";
            DataTable result = DBConnect.ExecuteQuery(sql, null);
            return result;
        }

        public bool IsEnabledGoods(int flag, string id)
        {
            string sql = $"UPDATE w_goods SET enabled = '{flag}' WHERE g_id = '{id}'";
            return DBConnect.Excute(sql);
        }
        public bool DeleteGood(GoodsDto good)
        {
            string sql = $"UPDATE w_goods SET isdelete = '{good.IsDelete}' WHERE g_id = '{good.GId}'";
            return DBConnect.Excute(sql);
        }
        public bool UpdateGood(GoodsDto good)
        {
            string sql1 = $"UPDATE w_goods SET goods_Id = '{good.GoodId}',goods_name = '{good.GoodName}',goods_time = '{good.GoodTime}' WHERE g_id = '{good.GId}' and isdelete = '0'";
            DBConnect.Excute(sql1);
            string sql2 = $"UPDATE w_ingoods SET good_Id = '{good.GoodId}',good_time = '{good.GoodTime}',good_name ='{good.GoodName}' WHERE good_marId = '{good.GId}'";
            DBConnect.Excute(sql2);
            return true;
        }
    }
}
