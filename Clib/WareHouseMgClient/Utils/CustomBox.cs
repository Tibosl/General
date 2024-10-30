using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseMgClient.Utils
{
    public class CustomBox
    {
        public static void Show(string title, string caption)
        {
            MessageBox.Show(title, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
