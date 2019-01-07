using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldAPI
{
    public abstract class BaseMessage : IMessage
    {
        protected ConfigurationHelper ConfigHelper;
        
        public BaseMessage()
        {
            ConfigHelper = new ConfigurationHelper();
        }
        public abstract string Render();
    }
}
