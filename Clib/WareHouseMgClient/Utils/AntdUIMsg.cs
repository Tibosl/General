using AntdUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseMgClient.Utils
{
    public static class AntdUIMsg
    {
        public static DialogResult MessageBox(this Window owner, string message,string title = "",MessageBoxButtons buttons = MessageBoxButtons.OK,MessageBoxIcon icon = MessageBoxIcon.None,bool closeButton = true)
        {
            var modalCfg = new Modal.Config(owner, title, message);
            modalCfg.Btns = CreateButtons(buttons, modalCfg);
            modalCfg.Icon = CreateIcon(icon);
            var ret = DialogResult.OK;
            modalCfg.OkType = TTypeMini.Primary;
            modalCfg.OnBtns = (btn) => 
            {
                switch (btn.Name)
                {
                    case "No":
                        ret = DialogResult.No; break;
                    case "Cancel":
                        ret = DialogResult.Cancel; break;
                    case "Retry":
                        ret = DialogResult.Retry; break;
                    case "Abort":
                        ret = DialogResult.Abort; break;
                    case "Ignore":
                        ret = DialogResult.Ignore; break;
                    default:
                        ret = DialogResult.OK; break;
                }
                return true;
            };

            if (Modal.open(modalCfg) == DialogResult.OK)
                switch (modalCfg.OkText)
                {
                    case "是":
                        ret = DialogResult.Yes; break;
                    case "重试":
                        ret = DialogResult.Retry; break;
                    case "放弃":
                        ret = DialogResult.Abort; break;
                    case "确定":
                    default:
                        ret = DialogResult.OK; break;
                }
            return ret;
        }
        private static Modal.Btn[] CreateButtons(MessageBoxButtons b, Modal.Config cfg)
        {
            cfg.CancelText = null; //禁用自带的取消按钮
            switch (b)
            {
                case MessageBoxButtons.OKCancel:
                    cfg.OkText = "是";
                    return new Modal.Btn[] {
                        new Modal.Btn("Cancel", "取消") 
                    };
                case MessageBoxButtons.YesNo:
                    cfg.OkText = "是";
                    return new Modal.Btn[] { 
                        new Modal.Btn("No", "否") 
                    };
                case MessageBoxButtons.YesNoCancel:
                    cfg.OkText = "是";
                    return new Modal.Btn[] {
                        new Modal.Btn("No", "否"),
                        new Modal.Btn("Cancel", "取消")
                    };
                case MessageBoxButtons.RetryCancel:
                    cfg.OkText = "重试";
                    return new Modal.Btn[] {
                        new Modal.Btn("Cancel", "取消") 
                    };
                case MessageBoxButtons.AbortRetryIgnore:
                    cfg.OkText = "放弃";
                    return new Modal.Btn[] {
                        new Modal.Btn("Retry", "重试"),
                        new Modal.Btn("Ignore", "忽略")
                    };
                case MessageBoxButtons.OK:
                default:
                    return new Modal.Btn[] { };
            }
        }
        private static TType CreateIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    return TType.Success;
                case MessageBoxIcon.Exclamation:
                    return TType.Warn;
                case MessageBoxIcon.Stop:
                    return TType.Error;
                case MessageBoxIcon.Question:
                    return TType.Info;
                case MessageBoxIcon.None:
                default:
                    return TType.None;
            }
        }
    }
}
