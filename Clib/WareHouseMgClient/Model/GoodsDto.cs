using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMgClient.Model
{
    public class GoodsDto : NotifyProperty
    {
        private bool selected = false;
        private string g_id;
        private string g_marId;
        private string good_Id;
        private string good_name;
        private string good_time;
        private int isdelete;
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
        public string GId
        {
            get { return g_id; }
            set
            {
                if (g_id == value) return;
                g_id = value;
                OnPropertyChanged(nameof(GId));
            }
        }
        public string GMarId
        {
            get { return g_marId; }
            set
            {
                if (g_marId == value) return;
                g_marId = value;
                OnPropertyChanged(nameof(GMarId));
            }
        }
        public string GoodId
        {
            get { return good_Id; }
            set
            {
                if (good_Id == value) return;
                good_Id = value;
                OnPropertyChanged(nameof(GoodId));
            }
        }
        public string GoodName
        {
            get { return good_name; }
            set
            {
                if (good_name == value) return;
                good_name = value;
                OnPropertyChanged(nameof(GoodName));
            }
        }
        public string GoodTime
        {
            get { return good_time; }
            set
            {
                if (good_time == value) return;
                good_time = value;
                OnPropertyChanged(nameof(GoodTime));
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
        public int IsDelete
        {
            get { return isdelete; }
            set
            {
                if (isdelete == value) return;
                isdelete = value;
                OnPropertyChanged(nameof(IsDelete));
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
