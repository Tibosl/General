using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMgClient.Model;

namespace WareHouseMgClient.Interface
{
    internal interface IGood
    {
        DataTable getGoods();
        bool IsEnabledGoods(int flag, string id);
        bool DeleteUser(GoodsDto good);
    }
}
