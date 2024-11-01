using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMgClient.Model;

namespace WareHouseMgClient
{
    public interface IUser
    {
        DataTable getUserInfo(string useraneme, string password);
        bool InsertUserInfo(string tabName,string[] columns, object[] values);
        bool ModifyPwd(UserDto user);
        bool UpdateUser(UserDto user);
        bool DeleteUser(UserDto user);
    }
}
