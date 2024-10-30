using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clib
{
    public class LogUtil
    {
        public static void WriteInfo(string info, string type,string filePath)
        {
            if (string.IsNullOrWhiteSpace(info)) return;
            //获取时间戳
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder str = new StringBuilder();
            str.AppendLine($"BEGIN-{time}");
            str.AppendLine($"{type}_{info}");
            str.AppendLine("END");
            string log = str.ToString();
            WriteToFile(filePath, log);
        }
        /// <summary>
        /// 写入日志，超过10m删除日志
        /// </summary>
        /// <param name="line"></param>
        public static void WriteToFile(string filePath,string line)
        {
            if (File.Exists(filePath))
            {
                FileInfo fi = new FileInfo(filePath);
                if (fi.Length > 1024 * 1024 * 10)
                {
                    fi.Delete();
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(line);
            File.AppendAllText(filePath, sb.ToString());
        }
    }
}
