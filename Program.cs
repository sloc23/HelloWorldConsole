using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HelloWorldAPI;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageFacade oFacade = new HelloWorldFacade(new ConsoleHelloWorldMessage());
            Console.WriteLine(oFacade.RenderMessage());
            
            oFacade = new HelloWorldFacade(new WebApplicationHelloWorldMessage());
            Console.WriteLine(oFacade.RenderMessage());
            
            oFacade = new HelloWorldFacade(new WindowsServiceHelloWorldMessage());
            Console.WriteLine(oFacade.RenderMessage());

            Console.Read();
        }
    }
}
