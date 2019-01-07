using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldAPI
{
    public class WebApplicationHelloWorldMessage : BaseMessage 
    {
        public WebApplicationHelloWorldMessage() : base()
        {

        }
        public override string Render()
        {
            return ConfigHelper.GetConfigurationAppSettingValue("WebApplicationHelloWorldMessage", "Error Retrieving Config Setting");
        }
    }
}
