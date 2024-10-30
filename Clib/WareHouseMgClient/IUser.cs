using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMgClient
{
    public interface IUser
    {
        DataTable getUserInfo(string useraneme, string password);
    }
}
