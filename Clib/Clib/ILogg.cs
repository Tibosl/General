using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logg
{
    public interface ILogg
    {
        void Log(string text);
        void Warn(string warn);
        void Error(string error);
    }
}
