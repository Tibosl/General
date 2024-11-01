using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMgClient.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WareHouseMgClient.Utils;

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
            string sql = "select * from w_goods where enabled = '0'";
            DataTable result = DBConnect.ExecuteQuery(sql, null);
            return result;
        }
    }
}
