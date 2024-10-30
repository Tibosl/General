using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace WareHouseMgClient.Utils
{
    public class DBConnect
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand commd = null;
        public static MySqlConnection getConn()
        {
            try
            {
                string connstr = "server=127.0.0.1;port=3306;user=root;password=root;database=warehouse;Charset=utf8;";
                conn = new MySqlConnection(connstr);
                conn.Open(); // 打开数据库
                return conn; // 返回数据库对象
            }
            catch (Exception ex)
            {
                CustomBox.Show("连接服务器失败！", "提示");
                Clib.Logg.Instance.Error(ex.Message);
                return null;
            }
        }
        public MySqlCommand getCommand(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, getConn());
            commd = cmd;
            return cmd;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public static void ConnectClose()
        {
            conn?.Close();
        }
    }
}
