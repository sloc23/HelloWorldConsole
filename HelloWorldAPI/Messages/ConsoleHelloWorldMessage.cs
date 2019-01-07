using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldAPI
{
    public class ConsoleHelloWorldMessage : BaseMessage
    {
        public ConsoleHelloWorldMessage() : base()
        {
        }

        public override string Render()
        {
            return ConfigHelper.GetConfigurationAppSettingValue("ConsoleHelloWorldMessage","Error Retrieving Config Setting");
        }
    }
}
