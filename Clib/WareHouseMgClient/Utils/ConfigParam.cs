using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseMgClient.Utils
{
    public class ConfigParam
    {
        public static bool getConfigParam() 
        {
            return Properties.Settings.Default.IsExist;
        }
        public static void setConfigParam(string settingName, object newValue) 
        {
            try
            {
                var propertyInfo = Properties.Settings.Default.GetType().GetProperty(settingName);
                if (propertyInfo != null)
                { 
                    var settingProperty = Properties.Settings.Default.Properties[settingName];
                    Properties.Settings.Default[settingName] = newValue;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                Clib.Logg.Instance.Error(ex.Message);
            }
        }
    }
}
