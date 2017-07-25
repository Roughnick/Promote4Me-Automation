using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Promote4Me_Automation.PageObjects.IntroPage;

namespace Promote4Me_Automation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver Driver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            Driver = new ChromeDriver(@"C:\Users\jgstu\Projects\4MELabs\Promote4Me\Promote4Me-Automation\chromedriver_win32");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var introPage = new IntroPage(Driver, "https://promote4.me/");
            introPage.Navigate();
        }
    }
}
