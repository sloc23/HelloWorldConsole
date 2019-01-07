using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;

namespace HelloWorldTest
{
    [TestClass]
    public class HWTests
    {

        [TestMethod]
        public void IF_ConfigValueExist_THEN_ReturnSetting()
        {
            ConfigurationHelper oConfigHelper = new ConfigurationHelper();
            string output = oConfigHelper.GetConfigurationAppSettingValue("WebApplicationHelloWorldMessage", "");
            Assert.AreEqual(output, "Hello World - Web Application");
        }

        [TestMethod]
        public void IF_ConfigValueMissing_THEN_ReturnDefault()
        {
            ConfigurationHelper oConfigHelper = new ConfigurationHelper();
            string output = oConfigHelper.GetConfigurationAppSettingValue("NonExistSetting", "Error Missing Configuration Setting");
            Assert.AreEqual(output, "Error Missing Configuration Setting");
        }

        [TestMethod]
        public void IF_MessageExist_THEN_RenderConsoleHelloWorldMessage()
        {
            IMessage oMessage = new ConsoleHelloWorldMessage();
            Assert.AreEqual(oMessage.Render(), "Hello World - Console Application");
        }

        [TestMethod]
        public void IF_MessageExist_THEN_WebApplicationWorldMessage()
        {
            IMessage oMessage = new WebApplicationHelloWorldMessage();
            Assert.AreEqual(oMessage.Render(), "Hello World - Web Application");
        }

        [TestMethod]
        public void IF_MessageExist_THEN_WindowsApplicationWorldMessage()
        {
            IMessage oMessage = new WindowsServiceHelloWorldMessage();
            Assert.AreEqual(oMessage.Render(), "Hello World - Windows Service Application");
        }

        [TestMethod]
        public void IF_Message_THEN_RenderMessageFromFacade()
        {
            IMessage oMessage = new ConsoleHelloWorldMessage();
            IMessageFacade oFacade = new HelloWorldFacade(oMessage);
            Assert.AreEqual(oFacade.RenderMessage(), oMessage.Render());

            oMessage = new WebApplicationHelloWorldMessage();
            oFacade = new HelloWorldFacade(oMessage);
            Assert.AreEqual(oFacade.RenderMessage(), oMessage.Render());

            oMessage = new WindowsServiceHelloWorldMessage();
            oFacade = new HelloWorldFacade(oMessage);
            Assert.AreEqual(oFacade.RenderMessage(), oMessage.Render());
        }
        
    }
}
