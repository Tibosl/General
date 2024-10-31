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
        public DataTable getUserInfo(string username, string password)
        {
            var sql = $"select * from w_user where username ='{username}' and password = '{password}'";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "id", username},
                { "password", password},
            };
            DataTable result = DBConnect.ExecuteQuery(sql, parameters);
            return result;
        }
        public bool insertUserInfo(string tabName,string[] columns, object[] values)
        {
            DBConnect.ExecuteInsert(tabName, columns,values);
            return true;
        }
    }
}
