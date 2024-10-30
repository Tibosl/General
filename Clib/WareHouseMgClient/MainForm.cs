using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseMgClient.Model;

namespace WareHouseMgClient
{
    public partial class MainForm : Form
    {
        protected UserDto _user;
        public MainForm(UserDto userDto)
        {
            InitializeComponent();
            _user = userDto;
        }
    }
}
