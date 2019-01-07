using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace HelloWorldAPI
{
    public class ConfigurationHelper
    {
        public ConfigurationHelper()
        {

        }

        public string GetConfigurationAppSettingValue(string key, string defaultValue)
        {
            if (string.IsNullOrEmpty(key))
                return null;

            var oAppSettingValue = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(oAppSettingValue))
                return defaultValue;

            return oAppSettingValue;
        }
    }
}
