using AntdUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WareHouseMgClient.Model;

namespace WareHouseMgClient.Utils
{
    public class DataTableHelp
    {
        public static List<T> ConvertDataTableToList<T>(DataTable dt) where T : new()
        {
            List<T> list = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                foreach (DataColumn column in dt.Columns) 
                {
                   PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                    if (prop != null && row[column] != DBNull.Value)
                    {
                        prop.SetValue(obj, row[column], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
        public static List<UserDto> DataTableToList<T>(DataTable dt) where T : new()
        {
            List<UserDto> list = new List<UserDto>();
            foreach (DataRow row in dt.Rows)
            {
                var userDto = new UserDto
                {
                    UId = row["u_id"].ToString(),
                    UserName = row["username"].ToString(),
                    PassWord = row["password"].ToString(),
                    Age = (int)row["age"],
                    Info = row["info"].ToString(),
                    CreateTime = row["createTime"].ToString(),
                    ModifyTime = row["modifyTime"].ToString(),
                    Sex = (int)row["sex"]
                };
                list.Add(userDto);
            }
            return list;
        }
    }
}
