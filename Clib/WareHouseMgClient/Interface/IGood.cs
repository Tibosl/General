using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMgClient.Interface
{
    internal interface IGood
    {
        DataTable getGoods();
    }
}
