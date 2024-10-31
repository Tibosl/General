using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMgClient.Model
{
    public class UserDto : NotifyProperty
    {
        private bool selected = false;
        private string u_id;
        private string username;
        private string password;
        private int age;
        private string info;
        private string createTime;
        private string modifyTime;
        private int sex;
        private string sexStr;
        private bool enabled = false;
        private CellBadge cellBadge;
        private CellLink[] cellLinks;

        public bool Selected
        {
            get { return selected; }
            set
            {
                if (selected == value) return;
                selected = value;
                OnPropertyChanged(nameof(Selected));
            }
        }
        public string UId
        {
            get { return u_id; }
            set
            {
                if (u_id == value) return;
                u_id = value;
                OnPropertyChanged(nameof(UId));
            }
        }

        public string UserName
        {
            get { return username; }
            set
            {
                if (username == value) return;
                username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string PassWord
        {
            get { return password; }
            set
            {
                if (password == value) return;
                password = value;
                OnPropertyChanged(nameof(PassWord));
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age == value) return;
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public string Info
        {
            get { return info; }
            set
            {
                if (info == value) return;
                info = value;
                OnPropertyChanged(nameof(Info));
            }
        }
        public string CreateTime
        {
            get { return createTime; }
            set
            {
                if (createTime == value) return;
                createTime = value;
                OnPropertyChanged(nameof(CreateTime));
            }
        }
        public string ModifyTime
        {
            get { return modifyTime; }
            set
            {
                if (modifyTime == value) return;
                modifyTime = value;
                OnPropertyChanged(nameof(ModifyTime));
            }
        }
        public int Sex
        {
            get { return sex; }
            set
            {
                if (sex == value) return;
                sex = value;
                OnPropertyChanged(nameof(Sex));
            }
        }
        public string SexStr
        {
            get { return sexStr; }
            set
            {
                if (sexStr == value) return;
                sexStr = value;
                OnPropertyChanged(nameof(SexStr));
            }
        }
        public bool Enabled
        {
            get { return enabled; }
            set
            {
                if (enabled == value) return;
                enabled = value;
                OnPropertyChanged(nameof(Enabled));
            }
        }
        

        public CellBadge CellBadge
        {
            get { return cellBadge; }
            set
            {
                if (cellBadge == value) return;
                cellBadge = value;
                OnPropertyChanged(nameof(CellBadge));
            }
        }

        public CellLink[] CellLinks
        {
            get { return cellLinks; }
            set
            {
                if (cellLinks == value) return;
                cellLinks = value;
                OnPropertyChanged(nameof(CellLinks));
            }
        }
    }
}
