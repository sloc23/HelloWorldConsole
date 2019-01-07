using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldAPI
{
    public class HelloWorldFacade : IMessageFacade
    {
        private IMessage HelloWorldMessage;

        public HelloWorldFacade(IMessage HelloWorldMessage)
        {
            this.HelloWorldMessage = HelloWorldMessage;
        }

        public string RenderMessage()
        {
            if (this.HelloWorldMessage != null)
                return HelloWorldMessage.Render();

            return string.Empty;
        }
    }
}
