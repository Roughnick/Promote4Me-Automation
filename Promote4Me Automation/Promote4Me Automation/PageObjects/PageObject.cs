using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Promote4Me_Automation.PageObjects
{
    public class PageObject
    {
        protected IWebDriver _driver;

        protected PageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate(string siteUrl)
        {
            _driver.Url = siteUrl;
        }
    }
}
