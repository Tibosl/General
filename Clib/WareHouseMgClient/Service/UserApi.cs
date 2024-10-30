using AntdUI;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMgClient.Model;
using WareHouseMgClient.Utils;

namespace WareHouseMgClient.Service
{
    public class UserApi : IUser
    {
        public DataTable getUserInfo(string useraneme, string password)
        {
            var sql = $"select * from w_user where username ='{useraneme}' and password = '{password}'";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "id", useraneme},
                { "password", password},
            };
            DataTable result = DBConnect.ExecuteQuery(sql, parameters);
            return result;
        }
        public bool insertUserInfo(string[] columns, object[] values)
        {
            DBConnect.InsertData("w_user", columns,values);
            return true;
        }
    }
}
