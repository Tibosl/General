using Logg;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clib
{
    public class Logg : ILogg
    {
        public static readonly ILogg Instance = new Logg();
        private readonly string LOG_PATH = string.Empty;
        public Logg()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            dirPath = Path.Combine(dirPath, "Logg");
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            LOG_PATH = Path.Combine(dirPath, string.Format("{0}.{1}", DateTime.Now.ToString("yyyy-MM-dd"), "txt"));
        }

        public void Error(string error)
        {
            LogUtil.WriteInfo(error, "[ERROR]",LOG_PATH);
        }

        public void Log(string text)
        {
            LogUtil.WriteInfo(text, "[LOG]", LOG_PATH);
        }

        public void Warn(string warn)
        {
            LogUtil.WriteInfo(warn, "[WARN]", LOG_PATH);
        }
    }
}
