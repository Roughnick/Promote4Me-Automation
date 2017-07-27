using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Promote4Me_Automation.PageObjects.SignUp;
using System.IO;

namespace Promote4Me_Automation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver Driver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            var path = Path.GetFullPath("../chromedriver_win32");
            Driver = new ChromeDriver(path);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var signUpPage = new SignUpPage(Driver);
            signUpPage.Navigate("https://promote4.me/");
        }
    }
}
