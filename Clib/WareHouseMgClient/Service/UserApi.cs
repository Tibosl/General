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
        public DataTable getUserInfo(string username = "", string password = "")
        {
            string sql = string.Empty;
            Dictionary<string, object> parameters = null;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                sql = $"select * from w_user where username ='{username}' and password = '{password}'";
                parameters = new Dictionary<string, object>
                {
                    { "id", username},
                    { "password", password},
                };
            }
            else 
            {
                sql = "select * from w_user";
            }
            DataTable result = DBConnect.ExecuteQuery(sql, parameters);
            return result;
        }
        public bool insertUserInfo(string tabName,string[] columns, object[] values)
        {
            DBConnect.ExecuteInsert(tabName, columns,values);
            return true;
        }

        public bool modifyPwd(UserDto user)
        {
            string query = $"UPDATE w_user SET password = '{user.PassWord}' WHERE username = '{user.UserName}' && u_id = '{user.UId}'";
            return DBConnect.Excute(query);
        }
        public bool deleteUser(UserDto user) 
        {
            string query = $"DELETE FROM w_user WHERE u_id = '{user.UId}'";
            return DBConnect.Excute(query);
        }
    }
}
