using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldAPI
{
    public class WindowsServiceHelloWorldMessage : BaseMessage
    {
        public WindowsServiceHelloWorldMessage() : base()
        {

        }

        public override string Render()
        {
            return ConfigHelper.GetConfigurationAppSettingValue("WindowsServiceHelloWorldMessage", "Error Retrieving Config Setting");
        }
    }
}
