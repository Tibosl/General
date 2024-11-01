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
        public bool DeleteUser(GoodsDto good)
        {
            string query = $"UPDATE w_goods SET isdelete = '{good.IsDelete}' WHERE g_id = '{good.GId}'";
            return DBConnect.Excute(query);
        }
    }
}
