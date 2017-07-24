using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Promote4Me_Automation
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverGC;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            driverGC = new ChromeDriver(@"C:\Users\jgstu\Projects\4MELabs\Promote4Me\Promote4Me-Automation\chromedriver_win32");
        }

        [TestMethod]
        public void TestMethod1()
        {
            driverGC.Navigate().GoToUrl("https://promote4.me/");
        }
    }
}
