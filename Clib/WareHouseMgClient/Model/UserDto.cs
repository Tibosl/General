using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMgClient.Model
{
    public class UserDto
    {
        public string u_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string info { get; set; }
        public DateTime? createtime { get; set; }
        public DateTime? modifytime { get; set; }
        public int sex { get; set; }
    }
}
